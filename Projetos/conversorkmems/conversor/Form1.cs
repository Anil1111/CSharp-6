using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpacampos();
        }

        // /3,6 km para metros
        // .3,6 metro para km


        private void btnConverterKM_Click(object sender, EventArgs e)
        {
            txtMetros.Text = (Convert.ToDouble(txtvelocidade.Text)/3.6).ToString();
        }

        private void btnConverterMS_Click(object sender, EventArgs e)
        {
            txtvelocidade.Text = (Convert.ToDouble(txtMetros.Text) * 3.6).ToString();
        }

        public void limpacampos()
        {
            txtMetros.Text = "";
            txtvelocidade.Text = "";
        }
    }
}
