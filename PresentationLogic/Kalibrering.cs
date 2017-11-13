using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PresentationLogic
{
    public partial class Kalibrering : Form
    {
        public Kalibrering()
        {
            InitializeComponent();
        }
        private void btnAfslutKali_Click(object sender, EventArgs e)
        {
            if (ListBoxMåltTryk.MultiColumn.ToString().Length >= 3) // enable efter 3 tryk i listen
            {
               btnAfslutKali.Enabled = true;
            }
  
        }
        private void btnNyMåling_Click(object sender, EventArgs e)
        {
            txtIndtastTryk.Clear();
            txtMåltTryk.Clear();
           
        }
        private void btnSletMåling_Click(object sender, EventArgs e)
        {
            // tjek om metoden til at slette markerede items virker!!!!
            foreach (string item in ListBoxMåltTryk.Items)
            {
                string removelistitem = "Linje";
                if (item.Contains(removelistitem))
                {
                    ListBoxMåltTryk.Items.Remove(item);
                }
            }
            // overvej denne metode, hvis forrige er forkert. 
         //https://stackoverflow.com/questions/13149486/delete-selected-items-from-listbox
          
        }

        private void chartMåltTryk_Click(object sender, EventArgs e)
        {

        }
    }
}
