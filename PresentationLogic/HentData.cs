using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public HentData(IBusinessLogic iBusinessLogic)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
        }

        private void HentData_Load(object sender, EventArgs e)
        {

        }

        private void btn_hentData_Click(object sender, EventArgs e)
        {
            //Resettting af værdier:   
            txt_indtastCpr.Clear();
            txt_kommentarer.Clear();
            txt_patientNavn.Clear();
            txt_patientCpr.Clear();   
            combo_ældreData.Items.Clear(); // Tjek om denne virker SS og LD 
            chart_måling.Series["Blodtryk"].Points.Clear();

            // Chart kode 
            PatientDTO patient = new PatientDTO();
            patient.CPR = txt_indtastCpr.Text;

            var patientOut = _iBusinessLogic.HentData(patient);

            if (!patientOut.FindesData)
            {
                MessageBox.Show("Intet data tilknyttet CPR-nummeret");
            }
            else
            { 
                List<MaalingDTO> separatedbpValues = _iBusinessLogic.RetrievedDivider(patientOut.Maalinger.MaaleData);
                 List<double> bpValues = _iBusinessLogic.ConvertArrayToDoubles(separatedbpValues[0].MaaleData);
            for (int i = 0; i < 5000; i++)
            {
                chart_måling.Series[0].Points.AddXY(i, 0.001, bpValues[i]);
            }

            }
            //Aksetitler til charten:
            chart_måling.ChartAreas[0].AxisX.Title = "Sekunder";
            chart_måling.ChartAreas[0].AxisY.Title = "mmHg";

            // Udfyld patient/ data oplysninger 

            txt_kommentarer.Text = patient.Maalinger.Kommentar;
            txt_patientNavn.Text = patient.Fornavn + patient.Efternavn;
            txt_patientCpr.Text = patient.CPR;
            combo_ældreData.Text = patient.Maalinger.MaaleTidspunkt.ToLongDateString(); // tjek om det virker SS og LD 

        }
    }
}
