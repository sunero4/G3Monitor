using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Interfaces;

namespace PresentationLogic
{
    public partial class Måling : Form
    {
        private IBusinessLogic _iBusinessLogic;
        private Monitoreringsindstillinger _monitoring;
        public Måling(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
        }
    }
}
