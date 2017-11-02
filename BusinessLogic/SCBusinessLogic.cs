using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic;
using DTO;

namespace BusinessLogic
{
    class SCBusinessLogic : iBusinessLogic
    {
        private IDataAccess _IDataAccess;

        public SCBusinessLogic(IDataAccess iDataAccess)
        {
            _iDataAccess = iDataAccess;
        }

        public bool CheckLogin(OPSygeplejerskeDTO op)
        {
            return _IDataAccess.CheckLogin(op);
        }
       
    }
}
