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

namespace PresentationLogic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Måling _myMåling;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // OP-sygeplejerske

            OPSygeplejerskeDTO opSygeplejerske = new OPSygeplejerskeDTO();
            opSygeplejerske.Brugernavn = txtBrugernavn.Text;
            opSygeplejerske.HashedPassword = PasswordSecurity.HashAndSaltPassword(txtPassword.Text, getSalt); 
                _iBusinessLogic.GetSalt(opSygeplejerske.Brugernavn)); 
           LoginBusniess validerLogin = new LoginBusniess();

            bool validerLogin = _iBusinessLogic.CheckLogin(opSygeplejerske);
                if (rbtnOP.Checked)
            {
                rbtnStartKalib.Enabled = false;
                if (validerLogin)
                {
                    if (rbtnStartMål.Checked)
                    {
                        this.Hide();
                        _myMåling = new Måling();
                        _myMåling.Show();
                    }
                    if (rbtnHentdata.Checked)
                    {
                        this.Hide();
                        _myMåling = new Måling();
                        _myMåling.Show();
                    }
                }

                if (validerLogin)
                    {
                        MessageBox.Show("Ikke gyldigt login, prøv igen. ");
                    }
            }

            // Tekniker Ikke færdig 
            
            bool BrugernavnTek = DTO(txtPassword.Text);
            bool PasswordTek = PasswordSecurity.HashAndSaltPassword(txtPassword.Text, salt:);
            if (rbtnTekniker.Checked)
            {
                rbtnHentdata.Enabled = false;
                rbtnStartMål.Enabled = false;
                if (BrugernavnTek && PasswordTek )
                {
                    if (rbtnStartKalib.Checked)
                    {
                        this.Hide();
                        _myMåling = new Måling();
                        _myMåling.Show();
                    }
                }
                if (BrugernavnTek == false || PasswordTek == false)
                {
                    MessageBox.Show("Ikke gyldigt login, prøv igen.");
                }
            }
        }
    }
}
