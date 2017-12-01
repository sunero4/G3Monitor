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
using TaskFactory = System.Threading.Tasks.TaskFactory;

namespace PresentationLogic
{
    public partial class Nulpunktsjustering : Form
    {
        private IBusinessLogic _businessLogic;
        private NulpunktsjusteringDTO _nulpunkt;
        private bool _isFinished;

        public Nulpunktsjustering(IBusinessLogic businessLogic, NulpunktsjusteringDTO nulpunkt)
        {
            InitializeComponent();
            _businessLogic = businessLogic;
            _nulpunkt = nulpunkt;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var nulpunkt = new NulpunktsjusteringDTO();
            var tf = new TaskFactory();
            var t = tf.StartNew(() => nulpunkt = _businessLogic.PerformAdjustment());

            Task.WaitAll(t);

            _nulpunkt = nulpunkt;
            _isFinished = true;
        }
    }
}
