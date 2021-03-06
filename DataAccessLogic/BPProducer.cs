﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using ObserverPattern;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    public class BPProducer
    {
        private ConcurrentQueue<BPDataContainer> _queue;
        private DAQData _daq;
        public bool CanRun { get; set; }
        private NI_DAQVoltage _daq2;
        public BPProducer(ConcurrentQueue<BPDataContainer> queue, DAQData daq)
        {
            _queue = queue;
            _daq = daq;
            _daq2 = new NI_DAQVoltage()
            {
                deviceName = "Dev3/ai0",
                rangeMinimumVolt = 0,
                rangeMaximumVolt = 5,
                sampleRateInHz = 1000,
                samplesPerChannel = 100
            };
        }



        /// <summary>
        /// Measures bloodpressure values
        /// </summary>
        /// <returns>Bloodpressure values</returns>
        public List<double> MeasureBP()
        {
            try
            {
                _daq2.getVoltageSeqBlocking();

                var data = _daq2.currentVoltageSeq;
                return data;
            }
            catch (Exception e)
            {
                throw new Exception("Målingen kunne ikke startes, tjek forbindelsen og prøv igen");
            }
        }

        /// <summary>
        /// Continuously measures data. Is to be run on its own thread
        /// </summary>
        public void GetData()
        { 
            var container = new BPDataContainer();
            CanRun = true;
            while (CanRun)
            {
                container.BloodPressure = MeasureBP();
                _queue.Enqueue(container);
            }
        }
    }
}
