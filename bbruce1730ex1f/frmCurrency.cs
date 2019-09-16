using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbruce1730ex1f
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnReset.PerformClick();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.686528";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = btnBhutan.Text + ":";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.0139400";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnGermany_Click(object sender, EventArgs e)
        {
            btnGermany.BackgroundImage = picGermany.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = btnGermany.Text + ":";
            txtCurrency.Text = "0.00";
            txtRate.Text = "1.10059";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnRussia_Click(object sender, EventArgs e)
        {
            btnRussia.BackgroundImage = picRussia.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            lblCurrency.Text = btnRussia.Text + ":";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.0156217";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void CalcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSD.Text)
                + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.686528";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
