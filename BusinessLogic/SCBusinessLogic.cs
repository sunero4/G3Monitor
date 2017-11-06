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

        public SCBusinessLogic(IDataAccess iDataAccess)
        {
            _iDataAccess = iDataAccess;
        }

        public bool CheckLogin(MedarbejderDTO medarbejder)
        {
            return _iDataAccess.CheckLogin(medarbejder);
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            return _iDataAccess.GetSalt(medarbejder);
        }

        public byte[] HashAndSaltPassword(string password, byte[] salt)
        {
            return PasswordSecurity.HashAndSaltPassword(password, salt); 
        }
    }
}
