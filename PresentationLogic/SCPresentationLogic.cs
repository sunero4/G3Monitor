using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace PresentationLogic
{
    public class SCPresentationLogic : IPresentationLogic
    {
        private IBusinessLogic _businessLogic;

        public SCPresentationLogic(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }


        public void StartUpGui()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new Login(_businessLogic));
        }
    }
}
