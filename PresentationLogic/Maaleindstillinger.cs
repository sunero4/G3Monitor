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
using static System.Int32;
using Interfaces;
using ObserverPattern;

namespace PresentationLogic
{
    public partial class Maaleindstillinger : Form
    {
        private Monitoreringsindstillinger _monitoring;
        private IBusinessLogic _iBusinessLogic;
        private Måling _maalingForm;
        private Maaleindstillinger _maaleindstillinger;

        public Maaleindstillinger(IBusinessLogic iBusinessLogic, Monitoreringsindstillinger monitoring)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
            _monitoring = monitoring;
        }

        private void btnGemIndstillinger_Click(object sender, EventArgs e)
        {
            if (TryParse(txtMinsys.Text, out var minSys) && TryParse(txtMaksSys.Text, out var maxSys) &&
                TryParse(txtMinDia.Text, out var minDia) && TryParse(txtMaksDia.Text, out var maxDia))
            {
                _monitoring = new Monitoreringsindstillinger()
                {
                    MinimumSystolic = minSys,
                    MaximumSystolic = maxSys,
                    MinimumDiastolic = minDia,
                    MaximumDiastolic = maxDia,
                    Saving = rbtnØnskerGem.Checked,
                    Patient = new PatientDTO()
                    {
                        CPR = txtCPR.Text,
                        Fornavn = txtFornavn.Text,
                        Efternavn = txtEfternavn.Text,
                        ListOperation = new List<OperationsDTO>()
                        {
                            new OperationsDTO()
                            {
                                MaaleTidspunkt = DateTime.Now,
                                Kommentar = txtKommentar.Text
                            }
                        }
                        
                    }
                };
                _iBusinessLogic.SetMonitoring(_monitoring);
            }

            this.Close();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("CPR-nummer er ugyldigt, vil du fortsætte alligvel?", "Ugyldigt CPR-nummer", MessageBoxButtons.YesNo);
            if (_iBusinessLogic.CPRchecker(txtCPR.Text))
            {
                var patientInfo = _iBusinessLogic.GetPatientInfo(new PatientDTO() { CPR = txtCPR.Text });
                txtFornavn.Text = patientInfo.Fornavn;
                txtEfternavn.Text = patientInfo.Efternavn;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                var patientInfo = _iBusinessLogic.GetPatientInfo(new PatientDTO() { CPR = txtCPR.Text });
                txtFornavn.Text = patientInfo.Fornavn;
                txtEfternavn.Text = patientInfo.Efternavn;
            }
            else if (dialogResult == DialogResult.No)
            {
                // ingen kode, messageBox lukker ned og går tilbage til måleindstillingsformen
            }



        }
    }
}
