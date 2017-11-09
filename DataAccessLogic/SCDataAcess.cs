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
        private IRetrivedData retrivedData; 
        private Salt salt; 

        public SCDataAcess()
        {
            retrivedData = new RetrivedData();
            salt = new Salt();
        }

        public MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder)
        {
            return retrivedData.CheckLogin(medarbejder);
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            return salt.GetSalt(medarbejder); 
        }
    }

}

