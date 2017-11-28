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
    public partial class Nulpunktsjustering : Form
    {
        private IBusinessLogic _businessLogic;
        private NulpunktsjusteringDTO _nulpunkt;
        public Nulpunktsjustering(IBusinessLogic businessLogic, NulpunktsjusteringDTO nulpunkt)
        {
            InitializeComponent();
            _businessLogic = businessLogic;
            _nulpunkt = nulpunkt;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _nulpunkt = _businessLogic.PerformAdjustment();
        }
    }
}
