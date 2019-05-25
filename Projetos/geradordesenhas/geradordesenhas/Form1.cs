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

        //aumenta o numero do tamanho da senha
        private void BtnMais_Click(object sender, EventArgs e)
        {
            txtTamanhosenha.Text = Convert.ToString(Convert.ToInt32(txtTamanhosenha.Text) + 1);
        }

        //diminui o numero do tamanho da senha
        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTamanhosenha.Text) > 1)
                txtTamanhosenha.Text = Convert.ToString(Convert.ToInt32(txtTamanhosenha.Text) - 1);
        }

        //limpa a senha
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtSaidasenha.Text = "";
        }

        //gera a senha
        private void BtnGerar_Click(object sender, EventArgs e)
        {
            variavelconstrucaodesenha = "";
            txtSaidasenha.Text = "";
            Random rnd = new Random();
            string saidadesenha ="";

            try
            {
                //constroi a variavel com todos os caracters 
                if (chkNumeros.Checked)
                    variavelconstrucaodesenha += txtNumeros.Text;
                if (chkLetrasminusculas.Checked)
                    variavelconstrucaodesenha += txtLetrasminusculas.Text;
                if (chkLetrasmaiusculas.Checked)
                    variavelconstrucaodesenha += txtLetrasmaiusculas.Text;
                if (chkCaracteresespeciais.Checked)
                    variavelconstrucaodesenha += txtCaracteresespeciais.Text;


                for (int quantiadesenhas = 0; quantiadesenhas < Int32.Parse(txtQuantiadeSenhasgeradas.Text); quantiadesenhas++)
                {
                    for (int aux = 0; aux < Int32.Parse(txtTamanhosenha.Text); aux++)
                    {
                        //txtSaidasenha.Text += variavelconstrucaodesenha[rnd.Next(variavelconstrucaodesenha.Length)]; //linha original
                        txtSaidasenha.Text += variavelconstrucaodesenha[rnd.Next(variavelconstrucaodesenha.Length)];

                    }
                    txtSaidasenha.Text += System.Environment.NewLine;


                }



            }
            catch(Exception erros)
            {
                MessageBox.Show(erros.ToString());
            }

        }

        private void BtnMenosQuantiadesenhasgeradas_Click(object sender, EventArgs e)
        {
           if (Convert.ToInt32(txtQuantiadeSenhasgeradas.Text) > 1)
            txtQuantiadeSenhasgeradas.Text = Convert.ToString(Convert.ToInt32(txtQuantiadeSenhasgeradas.Text) - 1);
           
        }

        private void BtnmaisQuantiadesenhasgeradas_Click(object sender, EventArgs e)
        {
            txtQuantiadeSenhasgeradas.Text = Convert.ToString(Convert.ToInt32(txtQuantiadeSenhasgeradas.Text) + 1);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            string[] conteudodatextboxparasalvar = new string[Convert.ToInt32(txtQuantiadeSenhasgeradas.Text)];

            for (int aux =0; aux < Convert.ToInt32(txtQuantiadeSenhasgeradas.Text); aux++)
            {
                conteudodatextboxparasalvar[aux] = txtSaidasenha.Lines[aux].ToString();
                
            }
            frmCaminhoparasalvar frmSalvar = new frmCaminhoparasalvar(conteudodatextboxparasalvar);
            frmSalvar.ShowDialog();
        }




    }
}
