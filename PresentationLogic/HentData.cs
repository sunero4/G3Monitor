﻿using System;
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

namespace PresentationLogic
{
    public partial class HentData : Form
    {
        private IBusinessLogic _iBusinessLogic;
        private PatientDTO _patient;
        private int _bpSegmentIndex;
        private int _operationIndex;

        public HentData(IBusinessLogic iBusinessLogic)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _bpSegmentIndex = 0;
            _operationIndex = 0;
        }

        private void HentData_Load(object sender, EventArgs e)
        {

        }

        private void btn_hentData_Click(object sender, EventArgs e)
        {
            var patient = new PatientDTO();
            patient.CPR = txt_indtastCpr.Text;

            _patient = _iBusinessLogic.HentData(patient);
            Chart(0);

            //Aksetitler til charten:
            chart_måling.ChartAreas[0].AxisX.Title = "Sekunder";
            chart_måling.ChartAreas[0].AxisY.Title = "mmHg";
        }

        private void Chart(int index)
        {
            //Resettting af værdier:   
            txt_indtastCpr.Clear();
            txt_kommentarer.Clear();
            txt_patientNavn.Clear();
            txt_patientCpr.Clear();
            combo_ældreData.Items.Clear(); // Tjek om denne virker SS og LD 
            chart_måling.Series["Blodtryk"].Points.Clear();
            // Chart kode 


            if (!_patient.FindesData)
            {
                MessageBox.Show("Intet data tilknyttet CPR-nummeret");
            }
            else
            {
                List<MaalingDTO> separatedbpValues = _patient.ListOperation[_operationIndex].Maaling;
                List<double> bpValues = _iBusinessLogic.ConvertArrayToDoubles(separatedbpValues[_bpSegmentIndex].MaaleData);
                for (int i = 0; i < 5000; i++)
                {
                    chart_måling.Series[0].Points.AddXY(i, 0.001, bpValues[i]);
                }

            }
       
            // Udfyld patient/ data oplysninger 

            txt_kommentarer.Text = _patient.ListOperation[_operationIndex].Kommentar;
            txt_patientNavn.Text = _patient.Fornavn + " " + _patient.Efternavn;
            txt_patientCpr.Text = _patient.CPR;
            combo_ældreData.Text = _patient.ListOperation[_bpSegmentIndex].MaaleTidspunkt.ToLongDateString(); // tjek om det virker SS og LD 

            //Set the scrollbar values to match the number of blood pressure segments for the current operation
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = _patient.ListOperation[_operationIndex].Maaling.Count;
        }

        private void combo_ældreData_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientDTO patient = new PatientDTO();
            _operationIndex = patient.ListOperation.FindIndex(x =>
                x.MaaleTidspunkt == Convert.ToDateTime(combo_ældreData.SelectedItem)); 
            Chart(_operationIndex);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue < e.NewValue)
            {
                _bpSegmentIndex++;
                Chart(_operationIndex);
            }
        }
    }
}
