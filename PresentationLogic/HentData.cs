using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using DTO;
using ObserverPattern;

namespace PresentationLogic
{
    public partial class HentData : Form
    {
        private IBusinessLogic _iBusinessLogic;
        private PatientDTO _patient;
        private int _bpSegmentIndex;
        private int _operationIndex;
        private Login _login;
        private bool _filterType;
        public HentData(IBusinessLogic iBusinessLogic)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _bpSegmentIndex = 0;
            _operationIndex = 0;
            _filterType = true;
        }

        private void HentData_Load(object sender, EventArgs e)
        {

        }

        private void btn_hentData_Click(object sender, EventArgs e)
        {
            var tempPatient = new PatientDTO() {CPR = txt_indtastCpr.Text};
            var patient = _iBusinessLogic.GetPatientInfo(tempPatient);
            txt_patientNavn.Text = patient.Fornavn + " " + patient.Efternavn;

            if (!patient.FindesData)
            {
                MessageBox.Show("Intet data tilknyttet CPR-nummeret");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                _patient = _iBusinessLogic.HentData(patient);
                Cursor.Current = Cursors.Default;
                Chart(0, _filterType);
                //Aksetitler til charten:
                chart_måling.ChartAreas[0].AxisX.Title = "Sekunder";
                chart_måling.ChartAreas[0].AxisY.Title = "mmHg";
                txt_patientCpr.Text = patient.CPR;
                txt_patientNavn.Text = patient.Fornavn + " " + patient.Efternavn;
            }

        }



        

        private void Chart(int index, bool filterType)
        {
            //Resettting af værdier:   
            txt_indtastCpr.Clear();
            txt_kommentarer.Clear();
            combo_ældreData.Items.Clear(); 
            chart_måling.Series["Blodtryk"].Points.Clear();
            // Chart kode 

            var separatedbpValues = _patient.ListOperation[_operationIndex].Maaling;

            if (separatedbpValues.Count > 0)
            {
                List<double> bpValues = _iBusinessLogic.ConvertArrayToDoubles(separatedbpValues[_bpSegmentIndex].MaaleData);
                var chartValues = _iBusinessLogic.FilterBPValues(bpValues, filterType);
                for (int i = 0; i < chartValues.Count; i++)
                {
                    chart_måling.Series[0].Points.AddXY(i * 0.005, chartValues[i]);
                }
                UpdateLabels(bpValues);
            }

            // Udfyld patient/ data oplysninger 
            txt_kommentarer.Text = _patient.ListOperation[_operationIndex].Kommentar;

            foreach (var item in _patient.ListOperation)
            {
                combo_ældreData.Items.Add(item.MaaleTidspunkt);
            }

            combo_ældreData.Text = _patient.ListOperation[index].MaaleTidspunkt.ToShortDateString(); // tjek om det virker SS og LD 

            //Set the scrollbar values to match the number of blood pressure segments for the current operation
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = _patient.ListOperation[_operationIndex].Maaling.Count;
        }

        private void combo_ældreData_SelectedIndexChanged(object sender, EventArgs e)
        {
            _operationIndex = _patient.ListOperation.FindIndex(x =>
                x.MaaleTidspunkt == Convert.ToDateTime(combo_ældreData.SelectedItem));
            _bpSegmentIndex = 0;
            Chart(_operationIndex, _filterType);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue < e.NewValue)
            {
                _bpSegmentIndex++;
                Chart(_operationIndex, _filterType);
            }
            if (e.OldValue > e.NewValue)
            {
                _bpSegmentIndex--;
                Chart(_operationIndex, _filterType);
            }
        }

        private void button1_Click(object sender, EventArgs e) // log ud knap
        {
            _login = new Login(_iBusinessLogic, new PresentationDataContainer());
            _login.Show();

            this.Close();
        }

        private void btn_filtreret_Click(object sender, EventArgs e)
        {
            _filterType = true;
            Chart(_operationIndex, _filterType);
            btn_filtreret.Enabled = false;
            btn_ufiltreret.Enabled = true;
        }

        private void btn_ufiltreret_Click(object sender, EventArgs e)
        {
            _filterType = false;
            Chart(_operationIndex, _filterType);
            btn_filtreret.Enabled = true;
            btn_ufiltreret.Enabled = false;
        }

        private void UpdateLabels(List<double> bpValues)
        {
            var container = _iBusinessLogic.CalculateValues(bpValues);
            lbl_middelBT_value.Text = Convert.ToString(container.AverageBloodPressure);
            lbl_sys_dia_value.Text = Convert.ToString(container.SystolicPressure + " / " + container.DiastolicPressure);
            lbl_puls_value.Text = Convert.ToString(container.Pulse);
        }
    }
}
