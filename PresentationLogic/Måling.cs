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
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Update()));
            }

            UpdateChart(_container);
            UpdateBPValues(_container);
        }

        private void UpdateChart(PresentationDataContainer container)
        {
            chart1.Series[0].Points.Clear();
            var data = container.GetSlidingWindow();
            for (int i = 0, n = data.Count; i < n; i++)
            {
                chart1.Series[0].Points.AddXY(data[i], i);
            }
        }

        private void UpdateBPValues(PresentationDataContainer container)
        {
            label_SysDia.Text = Convert.ToString(container.SystolicPressure) + " / " +
                                Convert.ToString(container.DiastolicPressure);
            label_MiddelBT.Text = Convert.ToString(container.AverageBloodPressure);
            label_Puls.Text = Convert.ToString(container.Pulse);
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
