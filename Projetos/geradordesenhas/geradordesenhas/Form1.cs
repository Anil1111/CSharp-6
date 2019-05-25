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
    public partial class GeradorSenhas : Form
    {
        public string variavelconstrucaodesenha;


        public GeradorSenhas()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            txtTamanhosenha.Text = Convert.ToString(Convert.ToInt32(txtTamanhosenha.Text) + 1);




        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            txtTamanhosenha.Text = Convert.ToString(Convert.ToInt32(txtTamanhosenha.Text) - 1);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtSaidasenha.Text = "";
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            txtSaidasenha.Text = "";
            variavelconstrucaodesenha = "";
            Random rnd = new Random();

            try
            {

                if (chkNumeros.Checked)
                    variavelconstrucaodesenha += txtNumeros.Text;
                if (chkLetrasminusculas.Checked)
                    variavelconstrucaodesenha += txtLetrasminusculas.Text;
                if (chkLetrasmaiusculas.Checked)
                    variavelconstrucaodesenha += txtLetrasmaiusculas.Text;
                if (chkCaracteresespeciais.Checked)
                    variavelconstrucaodesenha += txtCaracteresespeciais.Text;

               

                for (int aux = 0; aux < Int32.Parse(txtTamanhosenha.Text); aux++ )
                {
                    txtSaidasenha.Text += variavelconstrucaodesenha[rnd.Next(variavelconstrucaodesenha.Length)]; 
                }






                //txtSaidasenha.Text = variavelconstrucaodesenha;

            }
            catch(Exception erros)
            {
                MessageBox.Show(erros.ToString());
            }




        }
    }
}
