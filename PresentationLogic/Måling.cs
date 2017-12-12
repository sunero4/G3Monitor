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
using Timer = System.Windows.Forms.Timer;

namespace PresentationLogic
{
    public partial class Måling : Form, IPresentationObserver
    {
        private IBusinessLogic _iBusinessLogic;
        private Monitoreringsindstillinger _monitoring;
        private Maaleindstillinger _maaleindstillinger;
        private PresentationDataContainer _container;
        private Nulpunktsjustering _nulpunktForm;
        private NulpunktsjusteringDTO _nulpunkt;
        private Login _login;
        private System.Windows.Forms.Timer _timer;

        public Måling(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
            _container = container;
            _nulpunkt = new NulpunktsjusteringDTO();
            _timer = new Timer() {Interval = 120000};
            _timer.Tick += HandleAlarmDeactivationTimer;
            ChartSetup();
        }

        public new void Update()
        {
            UpdateBPValues(_container);
        }

        private void UpdateBPValues(PresentationDataContainer container)
        {
            //If called from another thread, invoke this method from the GUI thread. When called from
            //the GUI, no invoke is required and the code will enter the else-block.
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateBPValues(container)));
            }
            else
            {
                var data = container.FilteredBPValues;

                chart1.Series[0].Points.Clear();
                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[0].Points.Add(data[i], (i * 0.005));
                }
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
            btn_filtrerMåling.Enabled = false;
            btn_UfiltrerMåling.Enabled = true; 
        }

        private void btn_UfiltrerMåling_Click(object sender, EventArgs e)
        {
            _iBusinessLogic.CreateFilter(false);
            btn_filtrerMåling.Enabled = true;
            btn_UfiltrerMåling.Enabled = false;
        }

        private void btn_Nulpunktsjustering_Click(object sender, EventArgs e)
        {
            _nulpunktForm = new Nulpunktsjustering(_iBusinessLogic, _nulpunkt);
            _nulpunktForm.Show();
            btn_Indstillinger.Enabled = true;
        }

        private void btn_StartMåling_Click_1(object sender, EventArgs e)
        {
            try
            {
                btn_StopMåling.Enabled = true;
                _monitoring = _iBusinessLogic.GetMonitoring();
                var patient = _monitoring.Patient;
                _iBusinessLogic.GetPatientInfoForSaving(patient);
                _container.Attach(this);
                _iBusinessLogic.ToggleAlarmOn(_container, _monitoring);
                var t1 = new Thread(_iBusinessLogic.StartShowData);
                t1.IsBackground = true;
                t1.Start();

                btn_AktiverAlarm.Enabled = true;
                btn_DeaktiverAlarm.Enabled = true;
                btn_UfiltrerMåling.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Måling blev ikke foretaget, prøv igen.");
                
            }
            
        }

        private void btn_StopMåling_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil stoppe målingen?", "Stop måling", MessageBoxButtons.YesNo);
           
            if (dialogResult == DialogResult.Yes)
            {
                _iBusinessLogic.StopMeasurement();
                btn_AktiverAlarm.Enabled = false;
                btn_DeaktiverAlarm.Enabled = false;
                btn_UfiltrerMåling.Enabled = false;
                btn_filtrerMåling.Enabled = false;
                btn_StartMåling.Enabled = false;
                btn_StopMåling.Enabled = false;
                btn_Indstillinger.Enabled = false;  
                _iBusinessLogic.ToggleAlarmOff(_container);
            }
            else if (dialogResult == DialogResult.No)
            {
                // ingen kode, messageBox lukker ned og går tilbage til måling
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _login = new Login(_iBusinessLogic, _container);
            _iBusinessLogic.StopMeasurement();
            this.Close();

            _login.ShowDialog(); 
        }

        private void btn_Indstillinger_Click(object sender, EventArgs e)
        {
            _maaleindstillinger = new Maaleindstillinger(_iBusinessLogic, _monitoring, this);
            _maaleindstillinger.Show();
            btn_StartMåling.Enabled = true;
        }

        private void HandleAlarmDeactivationTimer(object sender, EventArgs e)
        {
            _iBusinessLogic.ToggleAlarmOn(_container, _monitoring);
            _timer.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MinimumSystolic = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MaximumSystolic = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MinimumDiastolic = Convert.ToInt32(numericUpDown3.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            _monitoring.MaximumDiastolic = Convert.ToInt32(numericUpDown4.Value);
        }

        private void btn_DeaktiverAlarm_Click_1(object sender, EventArgs e)
        {
            _iBusinessLogic.ToggleAlarmOff(_container);
            _timer.Start();
        }

        private void btn_AktiverAlarm_Click(object sender, EventArgs e)
        {
            _iBusinessLogic.ToggleAlarmOn(_container, _monitoring);
            _timer.Stop();
        }

        public void UpdateThresholds(int minSys, int maxSys, int minDia, int maxDia)
        {
            numericUpDown1.Value = minSys;
            numericUpDown2.Value = maxSys;
            numericUpDown3.Value = minDia;
            numericUpDown4.Value = maxDia;

            numericUpDown1.Text = Convert.ToString(minSys);
            numericUpDown2.Text = Convert.ToString(maxSys);
            numericUpDown3.Text = Convert.ToString(minDia);
            numericUpDown4.Text = Convert.ToString(maxDia);
        }

        private void ChartSetup()
        {
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisX.Maximum = 4;
            chart1.ChartAreas[0].AxisY.Minimum = 20;
            chart1.ChartAreas[0].AxisY.Maximum = 240;
            chart1.ChartAreas[0].AxisY.Interval = 20;
            chart1.ChartAreas[0].AxisX.Title = "Tid (sekunder)";
            chart1.ChartAreas[0].AxisY.Title = "Tryk (mmHg)";
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 200;
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 20;
        }

        private void Måling_Load(object sender, EventArgs e)
        {

        }
    }
}
