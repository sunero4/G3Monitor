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
using DTO;
using Interfaces;

namespace PresentationLogic
{
    public partial class Kalibrering : Form
    {
        private IBusinessLogic _iBusinessLogic;
        private KalibreringsDTO _kalibrering;
        public Kalibrering(IBusinessLogic iBusiness)
        {
            InitializeComponent();
            _iBusinessLogic = iBusiness;
            _kalibrering = new KalibreringsDTO();
        }
        private void btnAfslutKali_Click(object sender, EventArgs e)
        {
            // Man kan afslutte kalibreringen, hvis der er 3 items i listboxen 
            if (ListBoxMåltTryk.MultiColumn.ToString().Length >= 3) 
            {
                btnAfslutKali.Enabled = true;
            }
            else
                btnAfslutKali.Enabled = false;
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

        private void ScrollBarHældning_Scroll(object sender, ScrollEventArgs e)
        {

            // Scrollbar går op og ned 
            if (e.OldValue > e.NewValue)
            {
                _kalibrering.Slope -= 1;
                txtHældningskoefficient.Text = _kalibrering.ToString();
                txtHældningskoefficient.Text = _kalibrering.Slope.ToString();
            }
            if (e.OldValue < e.NewValue)
            {
                txtHældningskoefficient.Text = _kalibrering.ToString();
                txtHældningskoefficient.Text = _kalibrering.Slope.ToString();
            }
        }

        private void txtHældningskoefficient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
