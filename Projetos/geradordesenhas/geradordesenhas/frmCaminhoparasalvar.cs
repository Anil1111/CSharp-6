using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geradordesenhas
{
    public partial class frmCaminhoparasalvar : Form
    {
       // public string[] textoparasalvar;
        public frmCaminhoparasalvar()
        {
            InitializeComponent();
        }

        public frmCaminhoparasalvar(string[] textoparasalvar)
        {
            InitializeComponent();

             //this.textoparasalvar = textoparasalvar;

             for (int aux = 0; aux < textoparasalvar.Length ; aux++)
             {
                //this.textoparasalvar[aux] = textoparasalvar[aux];
                 txtSenhas.Text += textoparasalvar[aux].ToString();
                 txtSenhas.Text += System.Environment.NewLine;
             }


        }




        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txtNomearquivo.Text, txtSenhas.Text);

        }
    }
}
