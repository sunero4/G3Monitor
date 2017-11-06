using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    class SCDataAcess: IDataAccess

    {
        private LoginData loginData;
        private Salt salt; 

        public SCDataAcess()
        {
            loginData = new LoginData();
            salt = new Salt();
        }

        public bool CheckLogin(MedarbejderDTO medarbejder)
        {
            return loginData.CheckLogin(medarbejder);
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            return salt.GetSalt(medarbejder); 
        }
    }

}

