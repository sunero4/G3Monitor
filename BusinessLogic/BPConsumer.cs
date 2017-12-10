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
    public class BPConsumer : MeasurementSubjectBL
    {
        private ConcurrentQueue<BPDataContainer> _queue;
        private AutoResetEvent _event;
        public List<double> BPState { get; set; }
        private IDataAccess _dataAccess;
        private IFilter _filtering;
        private KaliAndZero _kaliAndZero;
        private Saving _saving;
        private PatientDTO _patient;
        private AutoResetEvent _savingEvent;

        public bool CanRun { get; set; }

        public BPConsumer(ConcurrentQueue<BPDataContainer> queue, IDataAccess dataAccess, AutoResetEvent autoResetEvent, IFilter filter, KaliAndZero kaliAndZero, PatientDTO patient)
        {
            _queue = queue;
            _dataAccess = dataAccess;
            _event = autoResetEvent;
            _filtering = filter;
            _kaliAndZero = kaliAndZero;
            _savingEvent = new AutoResetEvent(false);
            _saving = new Saving(dataAccess, _savingEvent);
            _patient = patient;
        }

        public void HandleData()
        {
            BPDataContainer container;
            List<double> filteredData = new List<double>();
            while (!_queue.TryDequeue(out container))
            {
                Thread.Sleep(0);
            }

            filteredData = _kaliAndZero.AddKalibreringAndZero(container.BloodPressure);


            BPState = filteredData;
            //Set eventet sååååå controlleren får at vide den skal læse BPState
            _event.Set();

            _saving.Values = BPState;
            _savingEvent.Set();
        }

        public void Run(object patient)
        {
            var patientIn = (PatientDTO) patient;
            CanRun = true;

            var t1 = new Thread(_dataAccess.StartProducer);
            t1.IsBackground = true;
            t1.Start();

            var t2 = new Thread(_saving.StartSaving);
            t2.IsBackground = true;
            t2.Start(patientIn);

            while (CanRun)
            {
                HandleData();
            }
            if (!CanRun)
            {
                _dataAccess.StopProducer();
                _saving.CanRun = false;
            }
        }
    }
}
