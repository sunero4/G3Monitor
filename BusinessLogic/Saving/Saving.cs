using System.Collections.Generic;
using System.Threading;
using DTO;
using Interfaces;

namespace BusinessLogic
{
    public class Saving
    {
        private IDataAccess _dataAccess;
        private List<double> _bpValues;
        private int _sekvensNummer;
        private AutoResetEvent _autoResetEvent;

        public PatientDTO Patient { get; set; }
        public List<double> Values { get; set; }
        public bool CanRun { get; set; }

        public Saving(IDataAccess dataAccess, AutoResetEvent autoResetEvent)
        {
            _dataAccess = dataAccess;
            _sekvensNummer = 1;
            _autoResetEvent = autoResetEvent;
            _bpValues = new List<double>();
            CanRun = true;
            Patient = new PatientDTO();
        }

        /// <summary>
        /// Saves the initial data that does not need to be saved continuously (patient and operation)
        /// </summary>
        /// <param name="patient">Patient to save data for</param>
        public void SaveInitial(PatientDTO patient)
        {
            Patient = patient;
            _dataAccess.SaveInitial(patient);
        }


        /// <summary>
        /// Saves the measurement data
        /// </summary>
        /// <param name="patient">Patient to save data for</param>
        public void SaveMeasurement(PatientDTO patient)
        {
            _dataAccess.SaveBloodPressureData(patient);
        }

        /// <summary>
        /// Saves patient and operation data initially, and continuously saves measurement data
        /// </summary>
        /// <param name="patient">Patient to save data for</param>
        public void StartSaving(object patient)
        {
            var patientIn = (PatientDTO) patient;

            SaveInitial(patientIn);
            
            while (CanRun)
            {
                _autoResetEvent.WaitOne();
                SetBuffer(Values);
                if (_bpValues.Count >= 5000)
                {
                    var bytes = DataConverter.ConvertDoublesToByteArray(_bpValues);
                    Patient.ListOperation[0].Maaling = new List<MaalingDTO>();
                    Patient.ListOperation[0].Maaling.Add(new MaalingDTO()
                    {
                        MaaleData = bytes,
                    });
                    SaveMeasurement(Patient);
                    Patient.ListOperation[0].Maaling.Clear();
                    _bpValues.Clear();
                }
            }
        }

        public void SetBuffer(List<double> data)
        {
            foreach (var bp in data)
            {
                _bpValues.Add(bp);
            }
        }
    }
}
