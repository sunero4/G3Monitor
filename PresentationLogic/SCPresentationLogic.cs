using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using ObserverPattern;

namespace PresentationLogic
{
    public class SCPresentationLogic : IPresentationLogic
    {
        private IBusinessLogic _businessLogic;
        private PresentationDataContainer _container;
        public SCPresentationLogic(IBusinessLogic businessLogic, PresentationDataContainer container)
        {
            _businessLogic = businessLogic;
            _container = container;
        }


        public void StartUpGui()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new Login(_businessLogic, _container));
        }
    }
}
