using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbruce1730ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.686734";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.10615";
            txtAmountRussia.Text = "0.00";
            txtRateRussia.Text = "0.0152549";
            txtAmountUganda.Text = "0.00";
            txtRateUganda.Text = "0.000271938";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                    Convert.ToDecimal(txtAmountAustralia.Text)
                        * Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                    Convert.ToDecimal(txtAmountEuro.Text)
                        * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }

        private void russiaTextChanged(object sender, EventArgs e)
        {
            txtUSDRussia.Text = (
                    Convert.ToDecimal(txtAmountRussia.Text)
                        * Convert.ToDecimal(txtRateRussia.Text)).ToString("0.00");
        }

        private void ugandaTextChanged(object sender, EventArgs e)
        {
            txtUSDUganda.Text = (
                    Convert.ToDecimal(txtAmountUganda.Text)
                        * Convert.ToDecimal(txtRateUganda.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                    Convert.ToDecimal(txtUSDAustralia.Text)
                        + Convert.ToDecimal(txtUSDEuro.Text)
                        + Convert.ToDecimal(txtUSDRussia.Text)
                        + Convert.ToDecimal(txtUSDUganda.Text)).ToString("0.00");

        }
    }
}
