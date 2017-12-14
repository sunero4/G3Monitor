using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
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

        /// <summary>
        /// Handles consuming of data from the producer - is to be run continuously on its own thread
        /// </summary>
        public void HandleData()
        {
            BPDataContainer container;
            List<double> filteredData = new List<double>();
            while (!_queue.TryDequeue(out container))
            {
                //Yield
                Thread.Sleep(0);
            }

            filteredData = _kaliAndZero.AddKalibreringAndZero(container.BloodPressure);


            BPState = filteredData;
            //Set eventet sååååå controlleren får at vide den skal læse BPState
            _event.Set();

            _saving.Values = BPState;
            _savingEvent.Set();
        }

        /// <summary>
        /// Starts the continuous process of consuming the data from the producer. Starts the producer and 
        /// optionally the saving process
        /// </summary>
        /// <param name="monitoring">Monitoring object that holds patient info and info about whether
        /// or not to save data</param>
        public void Run(object monitoring)
        {
            var monitorSettings = (Monitoreringsindstillinger) monitoring;
            var patientIn = (PatientDTO) monitorSettings.Patient;
            CanRun = true;

            var t1 = new Thread(_dataAccess.StartProducer);
            t1.IsBackground = true;
            t1.Start();

            if (monitorSettings.Saving)
            {
                var t2 = new Thread(_saving.StartSaving);
                t2.IsBackground = true;
                t2.Start(patientIn);
            }


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
