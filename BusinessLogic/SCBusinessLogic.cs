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
        public SCBusinessLogic(IDataAccess iDataAccess)
        {
        private Login _login;
       

        public SCBusinessLogic(IDataAccess iDataAccess, Login login)
        {   
            _iDataAccess = iDataAccess;
            _login = login; 
        }

        public bool CheckLogin(MedarbejderDTO medarbejder)
        {
            var medarbejderOut = _iDataAccess.CheckLogin(medarbejder);
            return _login.CheckLogin(medarbejder, medarbejderOut);
            
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
    }
}
