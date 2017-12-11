using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Filter;
using DTO;
using Interfaces;
using ObserverPattern;

namespace BusinessLogic
{
    public class ShowData
    {
        private Queue<double> _slidingWindow;
        private IFilter _filter;
        private IPulse _pulse;
        private ICalculateSysDia _sys;
        private ICalculateSysDia _dia;
        private IAverageBP _average;
        private PresentationDataContainer _container;
        private BPConsumer _consumer;
        private AutoResetEvent _event;
        public PatientDTO Patient { get; set; }
        public Monitoreringsindstillinger Monitoring { get; set; }
        public bool CanRun { get; set; }
        public IFilter Filter { get { return _filter; } set { _filter = value; } }

        public ShowData(PresentationDataContainer container, BPConsumer consumer, AutoResetEvent autoResetEvent, IFilter filter)
        {
            _pulse = new Pulse();
            _average = new AverageBloodPressure();
            _dia = new Diastolic();
            _sys = new Systolic();
            _container = container;
            _consumer = consumer;
            _event = autoResetEvent;
            CanRun = true;
            _slidingWindow = new Queue<double>();
            _filter = filter;
            Patient = new PatientDTO();
            FillWindow();
        }

public void HandleData()
{
    //Venter på et set event fra consumeren
    _event.WaitOne();
    var data = _consumer.BPState;

    SetSlidingWindow(data);

    data = GetSlidingWindow();

    var currentData = _filter.Smoothing(data);

    if (data.Count > 1900)
    {
        _container.Pulse = _pulse.Calculate(data);
        var timediff = _pulse.TimeDifferences(data);
        _container.AverageBloodPressure = _average.Calculate(data);
        _container.SystolicPressure = _sys.Calculate(data, timediff);
        _container.DiastolicPressure = _dia.Calculate(data, timediff);
    }

    _container.FilteredBPValues = currentData;

    //Datacontainer is the subject, tell it to notify its observers
    _container.Notify();
}

public void Start()
{
    CanRun = true;
    Thread t1 = new Thread(_consumer.Run);
    t1.Start(Monitoring);

            while (CanRun)
            {
                HandleData();
            }
            if (!CanRun)
            {
                _consumer.CanRun = false;
            }
    }
        public void SetSlidingWindow(List<double> data)
        {
            if (_slidingWindow.Count >= 4000)
            {
                _slidingWindow.DequeueMultipleElements(data.Count);
            }
            _slidingWindow.EnqueueMultipleElements(data);
        }

        public List<double> GetSlidingWindow()
        {
            return _slidingWindow.ToList();
        }

        private void FillWindow()
        {
            for (int i = 0; i < 4000; i++)
            {
                _slidingWindow.Enqueue(0);
            }
        }

    }
}