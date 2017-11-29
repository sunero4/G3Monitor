using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DTO;
using Interfaces;
using ObserverPattern;
using System.Media;

namespace PresentationLogic
{
    public partial class Måling : Form, IPresentationObserver
    {
        private IBusinessLogic _iBusinessLogic;
        private Monitoreringsindstillinger _monitoring;
        private PresentationDataContainer _container;
        private Nulpunktsjustering _nulpunktForm;
        private NulpunktsjusteringDTO _nulpunkt;
        public Måling(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
            _container = container;
            _nulpunkt = new NulpunktsjusteringDTO();
            numericMinSys.Text = _monitoring.MinimumSystolic.ToString();
            numericMaksSys.Text = _monitoring.MinimumSystolic.ToString();
            numericMinDia.Text = _monitoring.MinimumDiastolic.ToString();
            numericMaksDia.Text = _monitoring.MaximumDiastolic.ToString(); 

        }

        public new void Update()
        {
            UpdateBPValues(_container);
        }

        //private void UpdateChart(List<double> data) 
        //{
        //    if (InvokeRequired)
        //    {
        //        BeginInvoke(new Action(() => UpdateChart(data)));
        //    }
        //    else
        //    {
        //        chart1.Series[0].Points.Clear();
        //        for (int i = 0; i < data.Count; i++)
        //        {
        //            chart1.Series[0].Points.Add(data[i], i);
        //        }
        //        //var bleh = data.Count - 1;
        //        //for (int i = bleh; i < 4000; i++)
        //        //{
        //        //    chart1.Series[0].Points.AddXY(0, 0);
        //        //}
        //    }
        //}

        private void UpdateBPValues(PresentationDataContainer container)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateBPValues(container)));
            }
            else
            {
                var data = container.GetSlidingWindow();

                chart1.Series[0].Points.Clear();
                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[0].Points.Add(data[i], i);
                }

                //var bleh = data.Count - 1;
                //for (int i = bleh; i < 4000; i++)
                //{
                //    chart1.Series[0].Points.AddXY(0, 0);
                //}
            }
        }
        private void UpdateBPValues(PresentationDataContainer container)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateBPValues(container)));
            }
            else
            {

                label_SysDia.Text = Convert.ToString(container.SystolicPressure) + " / " +
                                    Convert.ToString(container.DiastolicPressure);
                label_MiddelBT.Text = Convert.ToString(container.AverageBloodPressure);
                label_Puls.Text = Convert.ToString(container.Pulse);
            }


            
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

        private void btn_Nulpunktsjustering_Click(object sender, EventArgs e)
        {
            _nulpunktForm = new Nulpunktsjustering(_iBusinessLogic, _nulpunkt);
        }

        private void btn_StartMåling_Click_1(object sender, EventArgs e)
        {
            _container.Attach(this);
            var t1 = new Thread(_iBusinessLogic.StartShowData);
            t1.Start();
            
            if (numericMinSys.Text >  )
            {
                
            }
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void btn_DeaktiverAlarm_Click(object sender, EventArgs e) // virker det?
        {
            timer.Interval = 120000;
            timer.Tick += timer_Tick;
            timer.Start();
            btn_DeaktiverAlarm.Enabled = false;
            _iBusinessLogic.CreateAlarm(false); //slår alarmen fra?
 
            _container.Detach(this);
            
        }
        void timer_Tick(object sender, System.EventArgs e)
        {
            btn_DeaktiverAlarm.Enabled = true;
            timer.Stop();
            _iBusinessLogic.CreateAlarm(true);
            _container.Attach(this);
        }

        private void btn_AktiverAlarm_Click(object sender, EventArgs e) // virker det?
        {
            _container.Attach(this);
            _iBusinessLogic.CreateAlarm(true);
        }
  
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MinimumSystolic = Convert.ToInt32(numericMinSys.Text);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MaximumSystolic = Convert.ToInt32(numericMaksSys.Text);  
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MinimumDiastolic = Convert.ToInt32(numericMinDia.Text);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MaximumDiastolic = Convert.ToInt32(numericMaksDia.Text); 
        }

      
    }
}
