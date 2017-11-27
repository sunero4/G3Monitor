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
        private RetrievedDataDivider _retrievedDataDivider;
        private DataConverter _dataConverter;
        private IFilter _filter;
        private BPConsumer _consumer;
        private AutoResetEvent _event;
        private ShowData _showData;

        public SCBusinessLogic(IDataAccess iDataAccess, ConcurrentQueue<BPDataContainer> queue, PresentationDataContainer container)
        {
            _event = new AutoResetEvent(false);
            _iDataAccess = iDataAccess;
            _nulpunkt = new Nulpunktsjustering();
            _login = new Login();
            _retrievedDataDivider = new RetrievedDataDivider();
            _dataConverter = new DataConverter();
            _consumer = new BPConsumer(queue, _iDataAccess, _event);
            _showData = new ShowData(container, queue, _consumer, _event);
            _filter = new FilterBP();
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
            if (patientDto.Maalinger.MaaleData == null)
            {
                patientDto.FindesData = false;
            }
            return patientDto;
        }

        public List<MaalingDTO> RetrievedDivider(byte[] bpValues)
        {
            return _retrievedDataDivider.RetrievedDivider(bpValues);
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
    }
}
