using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Alarm;
using BusinessLogic.Filter;
using DataAccessLogic;
using DTO;
using Interfaces;
using ObserverPattern;

namespace BusinessLogic
{
    public class SCBusinessLogic : IBusinessLogic
    {
        private IDataAccess _iDataAccess;
        private Nulpunktsjustering _nulpunkt;
        private Login _login;
        private IFilter _filter;
        private BPConsumer _consumer;
        private AutoResetEvent _event;
        private ShowData _showData;
        private NulpunktsjusteringDTO _nulpunktDTO;
        private KaliAndZero _kaliAndZero;
        private CPRChecker _checker;
        private PatientDTO _patientDTO;
        private KalibreringsAlgoritme _kalibreringsAlgoritme;
        private Monitoreringsindstillinger _monitoring;
        private IAlarm _alarm;


        public SCBusinessLogic(IDataAccess iDataAccess, ConcurrentQueue<BPDataContainer> queue,
            PresentationDataContainer container)
        {
            _event = new AutoResetEvent(false);
            _iDataAccess = iDataAccess;
            _nulpunkt = new Nulpunktsjustering(_iDataAccess);
            _login = new Login();
            _filter = new FilterBP();
            _patientDTO = new PatientDTO();
            _kaliAndZero = new KaliAndZero(_nulpunktDTO, GetCalibration());
            _consumer = new BPConsumer(queue, _iDataAccess, _event, _filter, _kaliAndZero, _patientDTO);
            _showData = new ShowData(container, _consumer, _event, _filter);
            _kalibreringsAlgoritme = new KalibreringsAlgoritme();
            _showData = new ShowData(container, _consumer, _event, _filter);
            _checker= new CPRChecker();

        }

        public bool CheckLogin(MedarbejderDTO medarbejder)
        {
            var medarbejderOut = _iDataAccess.CheckLogin(medarbejder);
            return _login.CheckLogin(medarbejder, medarbejderOut);
            
        }

        public List<double> ConvertArrayToDoubles(byte[] maaledata)
        {
            //var PatientOut = _iDataAccess.HentData(maaledata);
            return DataConverter.ConvertArrayToDoubles(maaledata);
            
        }

        public PatientDTO HentData(PatientDTO patient)
        {
            PatientDTO patientDto = _iDataAccess.HentData(patient);
            if (patientDto.ListOperation == null) // SS er i tvil om dette er rigtigt 
            {
                patientDto.FindesData = false;
            }
            return patientDto;
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            return _iDataAccess.GetSalt(medarbejder);
        }

        public byte[] HashAndSaltPassword(string password, byte[] salt)
        {
            return PasswordSecurity.HashAndSaltPassword(password, salt); 
        }

        public NulpunktsjusteringDTO PerformAdjustment()
        {
            var voltage = 4; //temporary
            return _nulpunkt.PerformAdjustment();
        }

        public PatientDTO GetPatientInfo(PatientDTO patient)
        {
            var patientOut = _iDataAccess.GetPatientInfo(patient);
            return patientOut;
        }

        public KalibreringsDTO GetCalibration()
        {
            return _iDataAccess.GetCalibration();
        }

        public void CreateFilter(bool button)
        {
            _filter = FilterFactory.CreateFilter(button);
        }

        public void RunConsumer()
        {
            _consumer.Run(_patientDTO);
        }

        public void StartShowData()
        {
            _showData.Start();
        }

        public void GetNulpunkt(NulpunktsjusteringDTO nulpunkt)
        {
            _nulpunktDTO = nulpunkt;
        }

        public void StartProducer()
        {
            _iDataAccess.StartProducer();
        }

        public void StopMeasurement()
        {
            _consumer.CanRun = false;
        }

        public void GetPatientInfoForSaving(PatientDTO patient)
        {
            _patientDTO = _monitoring.Patient;
            _patientDTO.ListOperation = new List<OperationsDTO>()
            {
                new OperationsDTO() {Kalibrering = GetCalibration().Slope, Nulpunktjustering = _nulpunktDTO.Nulpunktsjustering, MaaleTidspunkt = DateTime.Now, Kommentar = ""}
            };
            _showData.Patient = _patientDTO;
        }

        public double GetCalibrationPoint()
        {
            return _iDataAccess.GetSinglePressureValue();
        }

        public void PerformCalibration(KalibreringsDTO calibration)
        {
            _kalibreringsAlgoritme.CalibrateSystem(calibration);
        }

        public void SaveCalibration(KalibreringsDTO calibration)
        {
            _iDataAccess.SaveCalibration(calibration);
        }

        public bool CPRchecker(string cprnr)
        {
           return _checker.CPRchecker(cprnr); 
        }

        public Monitoreringsindstillinger GetMonitoring()
        {
            return _monitoring;
        }

        public void SetMonitoring(Monitoreringsindstillinger monitoring)
        {
            _monitoring = monitoring;
        }

        public void ToggleAlarmOn(PresentationDataContainer container, Monitoreringsindstillinger monitoring)
        {
            _alarm = AlarmFactory.CreateAlarm(container, monitoring);
            container.Attach(_alarm);
        }
    }
}
