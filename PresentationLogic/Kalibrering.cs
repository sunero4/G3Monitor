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
using System.Windows.Forms.VisualStyles;
using BusinessLogic;
using DTO;
using Interfaces;

namespace PresentationLogic
{
    public partial class Kalibrering : Form
    {
        private IBusinessLogic _iBusinessLogic;
        private KalibreringsDTO _kalibrering;
        private Login _login;
        public Kalibrering(IBusinessLogic iBusiness)
        {
            InitializeComponent();
            _iBusinessLogic = iBusiness;
            _kalibrering = new KalibreringsDTO()
            {
                ActualValue = new List<int>(),
                ExpectedValue = new List<int>()
            };

            chartMåltTryk.Series[0] = new Series("Expected value");
            chartMåltTryk.Series[1] = new Series("Actual value");
        }
        private void btnAfslutKali_Click(object sender, EventArgs e)
        {
            if (ListBoxMåltTryk.Items.Count >= 3)
            {
                _iBusinessLogic.SaveCalibration(_kalibrering);
            }
            else
            {
                MessageBox.Show("Insuficient amount of calibration points added");
            }

            //// Man kan afslutte kalibreringen, hvis der er 3 items i listboxen 
            //if (ListBoxMåltTryk.MultiColumn.ToString().Length >= 3) 
            //{
            //    btnAfslutKali.Enabled = true;
            //}
            //else
            //    btnAfslutKali.Enabled = false;
        }
        private void btnNyMåling_Click(object sender, EventArgs e)
        {
            txtIndtastTryk.Clear();
            txtMåltTryk.Clear();
          
                  // _kalibreringsDto.addValue(_iDataAccess.getSingleReading());
        }
        private void btnSletMåling_Click(object sender, EventArgs e)
        {
            // Slet målepunkt i listbox
            var index = ListBoxMåltTryk.SelectedIndex;
            ListBoxMåltTryk.Items.RemoveAt(index);
            


            //// tjek om metoden til at slette markerede items virker!!!!
            //foreach (string item in ListBoxMåltTryk.Items)
            //{
            //    string removelistitem = "Linje";
            //    if (item.Contains(removelistitem))
            //    {
            //        ListBoxMåltTryk.Items.Remove(item);
            //    }
            //}
        }

   

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnKalibrerMål_Click(object sender, EventArgs e)
        {
            var expected = Convert.ToInt32(txtIndtastTryk.Text);
            _kalibrering.ExpectedValue.Add(expected);

            double value = 0;

            var tf = new TaskFactory();
            var t = tf.StartNew(() => value = _iBusinessLogic.GetCalibrationPoint());

            Task.WaitAll(t);

            _kalibrering.ActualValue.Add(Convert.ToInt32(value));

            _iBusinessLogic.PerformCalibration(_kalibrering);

            UpdateChart(_kalibrering);
        }

        private void UpdateChart(KalibreringsDTO calibration)
        {
            chartMåltTryk.Series[0].Points.Clear();
            chartMåltTryk.Series[1].Points.Clear();

            for (int i = 0; i < calibration.ExpectedValue.Count; i++)
            {
                chartMåltTryk.Series[0].Points.AddXY(calibration.ExpectedValue[i], i);
                chartMåltTryk.Series[1].Points.AddXY(calibration.ActualValue[i], i);
            }

        }
    }
}
