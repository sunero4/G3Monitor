using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DTO;
using Interfaces;
using ObserverPattern;

namespace PresentationLogic
{
    public partial class Måling : Form, IPresentationObserver
    {
        private IBusinessLogic _iBusinessLogic;
        private Monitoreringsindstillinger _monitoring;
        private PresentationDataContainer _container;
        public Måling(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
            _container = container;
        }

        public new void Update()
        {
            label_SysDia.Text = Convert.ToString(_container.SystolicPressure) + " / " +
                                Convert.ToString(_container.DiastolicPressure);
            label_MiddelBT.Text = Convert.ToString(_container.AverageBloodPressure);
            label_Puls.Text = Convert.ToString(_container.Pulse);
            Chart(_container.FilteredBPValues);
        }

        public void AttachToSubject(MeasurementSubjectBL subject)
        {
            subject.Attach(this);
        }

        public void DetachFromSubject(MeasurementSubjectBL subject)
        {
            subject.Detach(this);
        }
    }
}
