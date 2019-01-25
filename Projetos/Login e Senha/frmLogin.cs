using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POO
{
    public partial class frmLogin : Form
    {

        SqlConnection sqlconn = null;
        string _sql = string.Empty;
        SqlCommand cmd = null;

        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            pictureBox1.Visible = true;
            TestearBancoOnline();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            logar();
        }
        /*Void de logar usando verifica se esta ou nao cadastrado no sistema*/
        public void logar()
        {
			
            sqlconn = FabricaDeConexao.CriarConexao();
            // Guardar o usuario e senha
            string usuario;
            string senha;

            try
            {
                //recebe das txt os valores
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;

                _sql = "SELECT COUNT(codSistema) FROM cad_sistema WHERE username = @usuario AND passwords = @senha ";

                 cmd = new SqlCommand(_sql, sqlconn);

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                
                /*
                 * a variavel (v) vai receber os os valores em int 
                 * se tiver a tabela certo ele vai recerber um valor 
                 * caso o valor for maior que 0 entao e verdadeiro 
                 * caso for 0 quer dizer que o usuario n esta cadastrado
                 */
                int v = (int)cmd.ExecuteScalar();

                if  (v > 0)
                {
                    this.Visible = false;
                    mdiPrincipal principal = new mdiPrincipal();
                    principal.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Usuário Inválido. Tente Novamente !", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }



            }
            catch (SqlException SQLEX)
            {
                MessageBox.Show("ERRO  " + SQLEX);
            }

        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

        }


        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
          

            if (e.KeyChar == 13) // 116 É O F5
            {

                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13 É O enter   116 é o F5    9 É TAB
            {

                btnOK.Focus();
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
         
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }


        //testa pra ver se o banco se encontra acesivel ou nao metodo boleano na Fabrica de conexao
        public void TestearBancoOnline()
        {
            /*utilizaei uma outra conexao com um metodo boleano para testar se o banco esta ou nao online*/
           FabricaDeConexao teste = new FabricaDeConexao();
                if (teste.testeConexao())
                {
                    label3.Text = "Online"; 
                    label3.ForeColor = Color.Green;

                }
                else{
                    label3.Text = "Off Line";
                    label3.ForeColor = Color.Red;
               
                }

        }

    }
    }