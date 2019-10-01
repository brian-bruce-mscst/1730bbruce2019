using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbruce1730ex2b
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal amountRussia = Convert.ToDecimal(txtAmountRussia.Text);
            decimal rateRussia = Convert.ToDecimal(txtRateRussia.Text);
            decimal usdRussia = amountRussia * rateRussia;
            txtUSDRussia.Text = usdRussia.ToString("0.00");

            decimal amountUganda = Convert.ToDecimal(txtAmountUganda.Text);
            decimal rateUganda = Convert.ToDecimal(txtRateUganda.Text);
            decimal usdUganda = amountUganda * rateUganda;
            txtUSDUganda.Text = usdUganda.ToString("0.00");

            decimal totalUSD = usdAustralia + usdEuro + usdRussia + usdUganda;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
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
    }
}
