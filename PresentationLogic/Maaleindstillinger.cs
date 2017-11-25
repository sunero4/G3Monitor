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
        public Maaleindstillinger(IBusinessLogic iBusinessLogic)
        {
            InitializeComponent();
            _iBusinessLogic = iBusinessLogic;
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
                        Maalinger = new MaalingDTO()
                        {
                            Kommentar = txtKommentar.Text
                        }
                    }
                };
            }
            _maalingForm = new Måling(_iBusinessLogic, _monitoring, new PresentationDataContainer());
            _maalingForm.Show();
            this.Close();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            var patientInfo = _iBusinessLogic.GetPatientInfo(new PatientDTO() {CPR = txtCPR.Text});
            txtFornavn.Text = patientInfo.Fornavn;
            txtEfternavn.Text = patientInfo.Efternavn;
        }
    }
}
