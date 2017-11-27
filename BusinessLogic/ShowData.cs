using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;
using ObserverPattern;

namespace BusinessLogic
{
    public class ShowData
    {
        private Queue<double> _slidingWindow;
        private ConcurrentQueue<BPDataContainer> _queue;
        private FilterFactory _filter;
        private Pulse _pulse;
        private Systolic _sys;
        private Diastolic _dia;
        private AverageBloodPressure _average;
        private PresentationDataContainer _container;
        private VoltageToPressureConversion _convert;
        private BPConsumer _consumer;
        private AutoResetEvent _event;

        public bool CanRun { get; set; }

        //public void SetSlidingWindow(List<double> data)
        //{
        //    if (_slidingWindow.Count == 4000)
        //    {
        //        _slidingWindow.DequeueMultipleElements(100);
        //    }
        //    _slidingWindow.EnqueueMultipleElements(data);
        //}

        public ShowData(PresentationDataContainer container, ConcurrentQueue<BPDataContainer> queue)
        {
            _filter = new FilterFactory();
            _pulse = new Pulse();
            _average = new AverageBloodPressure();
            _dia = new Diastolic();
            _sys = new Systolic();
            _convert = new VoltageToPressureConversion();
            _container = container;
            _consumer = consumer;
            _event = autoResetEvent;
            CanRun = true;
        }

        public void HandleData()
        {
            //Venter på et set event fra consumeren
            _event.WaitOne();
            var data = _consumer.BPState;

            _container.SetSlidingWindow(data);

            var currentData = _container.GetSlidingWindow();
            var tf = new TaskFactory();

            //Faster in parallel than sequential
            var t2 = tf.StartNew(() => _container.AverageBloodPressure = _average.Calculate(currentData));
            var t3 = tf.StartNew(() => _container.SystolicPressure = _sys.Calculate(currentData));
            var t4 = tf.StartNew(() => _container.DiastolicPressure = _dia.Calculate(currentData));
            var t5 = tf.StartNew(() => _container.Pulse = _pulse.Calculate(currentData));

            //Wait for all tasks to finish
            Task.WaitAll(t2, t3, t4, t5);

            //Datacontainer is the subject, tell it to notify its observers
            _container.Notify();
        }

        public void Start()
        {
            CanRun = true;
            Thread t1 = new Thread(_consumer.Run);
            t1.Start();

            while (CanRun)
            {
                HandleData();
            }
            if (!CanRun)
            {
                _consumer.CanRun = false;
            }
        }



    }
}
