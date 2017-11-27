using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccessLogic;
using Interfaces;
using ObserverPattern;
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
            var queue = new ConcurrentQueue<BPDataContainer>();
            var presentationContainer = new PresentationDataContainer();
            _dataAccess = new SCDataAcess(queue);
            _businessLogic = new SCBusinessLogic(_dataAccess, queue, presentationContainer);
            _presentationLogic = new SCPresentationLogic(_businessLogic, presentationContainer);

            var t1 = new Thread(_dataAccess.GetData);
            t1.Start();

            _presentationLogic.StartUpGui();
        }
    }
}
