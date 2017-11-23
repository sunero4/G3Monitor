using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccessLogic;
using Interfaces;
using PresentationLogic;

namespace G3Monitor
{
    class Program
    {
        private IDataAccess _dataAccess;
        private IBusinessLogic _businessLogic;
        private IPresentationLogic _presentationLogic;

        static void Main(string[] args)
        {
            Program prog = new Program();
        }

        public Program()
        {
            _dataAccess = new SCDataAcess();
            _businessLogic = new SCBusinessLogic(_dataAccess);
            _presentationLogic = new SCPresentationLogic(_businessLogic);
            _presentationLogic.StartUpGui();
        }
    }
}
