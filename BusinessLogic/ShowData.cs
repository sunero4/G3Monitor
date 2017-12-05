﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Filter;
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
        private IAverangePB _average;
        private PresentationDataContainer _container;
        private VoltageToPressureConversion _convert;
        private BPConsumer _consumer;
        private AutoResetEvent _event;
        //private KaliAndZero _kaliAndZero;

        public bool CanRun { get; set; }

        //public void SetSlidingWindow(List<double> data)
        //{
        //    if (_slidingWindow.Count == 4000)
        //    {
        //        _slidingWindow.DequeueMultipleElements(100);
        //    }
        //    _slidingWindow.EnqueueMultipleElements(data);
        //}

        public ShowData(PresentationDataContainer container, BPConsumer consumer, AutoResetEvent autoResetEvent, IFilter filter)
        {
            _pulse = new Pulse();
            _average = new AverageBloodPressure();
            _dia = new Diastolic();
            _sys = new Systolic();
            _convert = new VoltageToPressureConversion();
            _container = container;
            _consumer = consumer;
            _event = autoResetEvent;
            CanRun = true;
            _slidingWindow = new Queue<double>();
            _filter = filter;
        }

public void HandleData()
{
    //Venter på et set event fra consumeren
    _event.WaitOne();
    var data = _consumer.BPState;

    SetSlidingWindow(data);

    data = GetSlidingWindow();
    //var correctData = _kaliAndZero.AddKalibreringAndZero(data);
    var currentData = _filter.Smoothing(data);

    //var tf = new TaskFactory();

    //Faster in parallel than sequential
    if (data.Count > 1900)
    {
        _container.Pulse = _pulse.Calculate(data);
        var timediff = _pulse.TimeDifferences(data);
        _container.AverageBloodPressure = _average.Calculate(data);
        _container.SystolicPressure = _sys.Calculate(data, timediff);
        _container.DiastolicPressure = _dia.Calculate(data, timediff);
    }

    _container.FilteredBPValues = currentData;

    //var t2 = tf.StartNew(() => _container.AverageBloodPressure = _average.Calculate(currentData));
    //var t3 = tf.StartNew(() => _container.SystolicPressure = _sys.Calculate(currentData));
    //var t4 = tf.StartNew(() => _container.DiastolicPressure = _dia.Calculate(currentData));

    //if (data.Count == 4096)
    //{
    //    var t5 = tf.StartNew(() => _container.Pulse = _pulse.Calculate(currentData));
    //}


    //Wait for all tasks to finish
    //Task.WaitAll(t2, t3, t4);

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
        public void SetSlidingWindow(List<double> data)
        {
            if (_slidingWindow.Count >= 2000)
            {
                _slidingWindow.DequeueMultipleElements(data.Count);
            }
            _slidingWindow.EnqueueMultipleElements(data);
        }

        public List<double> GetSlidingWindow()
        {
            return _slidingWindow.ToList();
        }


}
}