using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccessLogic;
using DTO;
using Interfaces;
using ObserverPattern;

namespace BusinessLogic
{
    public class Saving
    {
        private IDataAccess _dataAccess;
        private List<double> _bpValues;
        private int _sekvensNummer;
        private AutoResetEvent _autoResetEvent;

        public PatientDTO Patient { get; set; }

        public bool CanRun { get; set; }

        public Saving(IDataAccess dataAccess, AutoResetEvent autoResetEvent)
        {
            _dataAccess = dataAccess;
            _sekvensNummer = 1;
            _autoResetEvent = autoResetEvent;
            CanRun = true;
        }

        public void SaveInitial(PatientDTO patient)
        {
            Patient = patient;
            _dataAccess.SaveInitial(patient);
        }

        public void SaveMeasurement(PatientDTO patient)
        {
            _dataAccess.SaveBloodPressureData(patient);
        }
        public void StartSaving(object patient)
        {
            var patientIn = (PatientDTO) patient;

            patientIn.CPR = "1234567811";
            patientIn.Fornavn = "Anders";
            patientIn.Efternavn = "Kloborg";
            patientIn.ListOperation = new List<OperationsDTO>()
            {
                new OperationsDTO()
                {
                    Kalibrering = 1,
                    Kommentar = "Test",
                    MaaleTidspunkt = DateTime.Now,
                    Nulpunktjustering = 1,
                    OperationsID = 5
                }
            };

            SaveInitial(patientIn);
            
            while (CanRun)
            {
                _autoResetEvent.WaitOne();
                if (_bpValues.Count >= 5000)
                {
                    var bytes = DataConverter.ConvertDoublesToByteArray(_bpValues);
                    Patient.ListOperation[0].Maaling[0].MaaleData = bytes;
                    Patient.ListOperation[0].Maaling[0].Sekvensnr = _sekvensNummer;
                    SaveMeasurement(Patient);
                    _sekvensNummer++;
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
