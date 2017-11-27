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
using ObserverPattern;

namespace PresentationLogic
{
    public partial class Måling : Form, IPresentationObserver
    {
        private IBusinessLogic _iBusinessLogic;
        private Monitoreringsindstillinger _monitoring;
        public Måling(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
        }

        public new void Update()
        {
            
        }

        public void AttachToSubject(MeasurementSubjectBL subject)
        {
            subject.Attach(this);
        }

        public void DetachFromSubject(MeasurementSubjectBL subject)
        {
            subject.Detach(this);
        }

        private void btn_filtrerMåling_Click(object sender, EventArgs e)
        {
            _iBusinessLogic.CreateFilter(true);
        }

        private void btn_UfiltrerMåling_Click(object sender, EventArgs e)
        {
            _iBusinessLogic.CreateFilter(false);
        }
    }
}
