using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Filter;
using DataAccessLogic;
using DTO;
using Interfaces;

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

        public SCBusinessLogic(IDataAccess iDataAccess)
        {
            _iDataAccess = iDataAccess;
            _nulpunkt = new Nulpunktsjustering();
            _login = new Login();
            _retrievedDataDivider = new RetrievedDataDivider();
            _dataConverter = new DataConverter();
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
            var voltage = _iDataAccess.GetVoltage();
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
    }
}
