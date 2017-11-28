using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        private DataConverter _dataConverter;
        private IFilter _filter;
        private BPConsumer _consumer;
        private AutoResetEvent _event;
        private ShowData _showData;
        private NulpunktsjusteringDTO _nulpunktDTO;
        private KaliAndZero _kaliAndZero;

        public SCBusinessLogic(IDataAccess iDataAccess, ConcurrentQueue<BPDataContainer> queue,
            PresentationDataContainer container)
        {
            _event = new AutoResetEvent(false);
            _iDataAccess = iDataAccess;
            _nulpunkt = new Nulpunktsjustering();
            _login = new Login();
            _dataConverter = new DataConverter();
            _consumer = new BPConsumer(queue, _iDataAccess, _event);
            _filter = new FilterBP();
            _kaliAndZero = new KaliAndZero(_nulpunktDTO, GetCalibration());
            _showData = new ShowData(container, queue, _consumer, _event, _filter, _kaliAndZero);
        }

        public bool CheckLogin(MedarbejderDTO medarbejder)
        {
            var medarbejderOut = _iDataAccess.CheckLogin(medarbejder);
            return _login.CheckLogin(medarbejder, medarbejderOut);
            
        }

        public List<double> ConvertArrayToDoubles(byte[] maaledata)
        {
            //var PatientOut = _iDataAccess.HentData(maaledata);
            return _dataConverter.ConvertArrayToDoubles(maaledata);
            
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
            return _nulpunkt.PerformAdjustment(voltage);
        }

        public PatientDTO GetPatientInfo(PatientDTO patient)
        {
            var patientOut = _iDataAccess.GetPatientInfo(patient);
            return patientOut;
        }

        public KalibreringsDTO GetCalibration()
        {
            return new KalibreringsDTO();
        }

        public void CreateFilter(bool button)
        {
            _filter = FilterFactory.CreateFilter(button);
        }

        public void RunConsumer()
        {
            _consumer.Run();
        }

        public void StartShowData()
        {
            _showData.Start();
        }

        public void GetNulpunkt(NulpunktsjusteringDTO nulpunkt)
        {
            _nulpunktDTO = nulpunkt;
        }
    }
}
