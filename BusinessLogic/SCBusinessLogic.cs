using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic;
using DTO;
using Interfaces;

namespace BusinessLogic
{
    class SCBusinessLogic : IBusinessLogic
    {
        private IDataAccess _iDataAccess;
        private Nulpunktsjustering _nulpunkt;
        private Login _login;
        private RetrievedDataDivider _retrievedDataDivider;
        private DataConverter _dataConverter;

        public SCBusinessLogic(IDataAccess iDataAccess)
        {
        }

        public SCBusinessLogic(IDataAccess iDataAccess, Login login, DataConverter dataConverter, RetrievedDataDivider retrievedDataDivider)
        {
            _dataConverter = dataConverter; 
            _iDataAccess = iDataAccess;
            _login = login;
            _retrievedDataDivider = retrievedDataDivider;
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
        //public KalibreringsDTO 
    }
}
