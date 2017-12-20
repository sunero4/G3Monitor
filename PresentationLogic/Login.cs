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
using BusinessLogic;
using DTO;
using Interfaces;
using ObserverPattern;

namespace PresentationLogic
{
    public partial class Login : Form
    {
        private IBusinessLogic _iBusinessLogic;
        private PresentationDataContainer _container;
        private Kalibrering _kalibrering;
        public Login(IBusinessLogic iBusiness, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusiness;
            _container = container;
        }
        private Måling _myMåling;
        private HentData _hentForm;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // OP-sygeplejerske
            if (rbtnOP.Checked && txtBrugernavn.Text.Length == 10)
            {
                OPSygeplejerskeDTO opSygeplejerske = new OPSygeplejerskeDTO();
                opSygeplejerske.Brugernavn = txtBrugernavn.Text;
                opSygeplejerske.HashedPassword = _iBusinessLogic.HashAndSaltPassword(txtPassword.Text, _iBusinessLogic.GetSalt(opSygeplejerske));
                bool validerLogin = _iBusinessLogic.CheckLogin(opSygeplejerske);
                if (validerLogin)
                {
                    if (rbtnStartMål.Checked)
                    {
                        this.Hide();
                        _myMåling = new Måling(_iBusinessLogic, new Monitoreringsindstillinger(), _container);
                        _myMåling.Show();
                    }
                    if (rbtnHentdata.Checked)
                    {
                        this.Hide();
                        _hentForm = new HentData(_iBusinessLogic);
                        _hentForm.Show();
                    }
                    else if(!rbtnStartMål.Checked && !rbtnHentdata.Checked)
                    {
                        MessageBox.Show("Vælg venligst den ønskede funktion.");
                    }
                }

                if (!validerLogin)
                    {
                        MessageBox.Show("Brugernavn eller password er forkert, prøv igen. ");
                    }
                }

            if (rbtnTekniker.Checked && txtBrugernavn.Text.Length == 8)
            {
                TeknikerDTO tekniker = new TeknikerDTO();
                tekniker.Brugernavn = txtBrugernavn.Text;
                tekniker.HashedPassword =
                    _iBusinessLogic.HashAndSaltPassword(txtPassword.Text, _iBusinessLogic.GetSalt(tekniker));
                var loginSucceeded = _iBusinessLogic.CheckLogin(tekniker);

                if (loginSucceeded)
                {
                    if (rbtnStartKalib.Checked)
                    {
                        this.Hide();
                        _kalibrering = new Kalibrering(_iBusinessLogic, txtBrugernavn.Text);
                        _kalibrering.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vælg venligst den ønskede funktion");
                    }
                }
                else
                {
                    MessageBox.Show("Brugernavn eller password er forkert, prøv igen.");
                }
            }
        }

        private void rbtnTekniker_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTekniker.Checked)
            {
                rbtnHentdata.Enabled = false;
                rbtnStartMål.Enabled = false;
                rbtnStartMål.Checked = false;
                rbtnHentdata.Checked = false;
                rbtnStartKalib.Enabled = true;
            }
        }

        private void rbtnOP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOP.Checked)
            {
                rbtnStartKalib.Enabled = false;
                rbtnStartKalib.Checked = false;
                rbtnHentdata.Enabled = true;
                rbtnStartMål.Enabled = true;
            }
        }
    }
        
    
}
