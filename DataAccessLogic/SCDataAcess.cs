using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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

        public bool CheckLogin(OPSygeplejerskeDTO op)
        {
            return loginData.CheckLogin(op);
        }

        public byte[] GetSalt(OPSygeplejerskeDTO op)
        {
            return salt.getSalt(op); 
        }
    }

}

