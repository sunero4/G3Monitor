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
        public Login(IBusinessLogic iBusiness, PresentationDataContainer container)
        {
            InitializeComponent();
            _iBusinessLogic = iBusiness;
            _container = container;
        }
        private Måling _myMåling;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // OP-sygeplejerske
                if (rbtnOP.Checked && txtBrugernavn.Text.Length == 10)
            {
                OPSygeplejerskeDTO opSygeplejerske = new OPSygeplejerskeDTO();
                opSygeplejerske.Brugernavn = txtBrugernavn.Text;
                opSygeplejerske.HashedPassword = _iBusinessLogic.HashAndSaltPassword(txtPassword.Text, _iBusinessLogic.GetSalt(opSygeplejerske));
                bool validerLogin = _iBusinessLogic.CheckLogin(opSygeplejerske);
                rbtnStartKalib.Enabled = false;
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
                        _myMåling = new Måling(_iBusinessLogic, new Monitoreringsindstillinger(), new PresentationDataContainer());
                        _myMåling.Show();
                    }
                }

                if (!validerLogin)
                    {
                        MessageBox.Show("Brugernavn eller password er forkert, prøv igen. ");
                    }
            }

            // Tekniker Ikke færdig, mangler forbindelsen til kalibrering 
            
            
            //if (rbtnTekniker.Checked && txtBrugernavn.Text.Length == 8 )
            //{
            //    TeknikerDTO _tekniker = new TeknikerDTO();
            //    _tekniker.Brugernavn = txtBrugernavn.Text;
            //    _tekniker.HashedPassword = _iBusinessLogic.HashAndSaltPassword(txtPassword.Text, _iBusinessLogic.GetSalt(_tekniker));
            //    bool validerLogin = _iBusinessLogic.CheckLogin(_tekniker);
            //    rbtnStartMål.Enabled = false;
            //    rbtnHentdata.Enabled = false; 
            //    if (validerLogin)
            //    {
            //        if (rbtnStartKalib.Checked)
            //        {
            //            this.Hide();
            //            _myStartKalib = new Kalibrering();
            //            _myStartKalib.Show();
            //        }
                  
            //    }

                //if (validerLogin)
                //{
                //    MessageBox.Show("Brugernavn eller password er forkert, prøv igen.. ");
                //}
            }
        }
        
    
}
