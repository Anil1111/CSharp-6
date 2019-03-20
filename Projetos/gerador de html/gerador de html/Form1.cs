using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerador_de_html
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            gerarhtml();
        }



        /*gerar o html em base ao site*/
        public void gerarhtml()
        {

            txtGeradorHtmlVisualizador.Clear();
            txtGeradorHtmlVisualizador.Text = @"<div class='footer-contato-endereco'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<font color = "+txtCor.Text+" >";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<strong>"+txtNomeEmpresa.Text+"</strong><br>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<strong>"+txtEndereço.Text+", "+txtNumero.Text+", "+txtCaixaPostal.Text+" </strong ><br>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<strong>"+txtbairro.Text+", "+txtCidade.Text+", CEP: "+txtCep.Text+" </strong>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</font>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</div><br>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<font size = 3 >";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span class='footer-copy'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span class='csstransforms3ds'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span class='cl-effect-2s'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<a href = 'http://p1s.com.br' target='_blank'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span data-hover='P1S - Prime Solutions'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<strong><font color = " + txtCor.Text + " > P1S - Prime Solutions</font></strong>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</a>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span> ";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<strong><font color = " + txtCor.Text + " > | </font ></strong >";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span class='csstransforms3d'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span class='cl-effect-2'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<a href = 'http://p1s-loja.com.br' target='_blank'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<span data-hover='e-comerce Solis plataforma loja virtual'>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"<strong><font color = " + txtCor.Text + " > e - comerce Solis plataforma loja virtual</font></strong>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</a>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</span>";
            txtGeradorHtmlVisualizador.Text += System.Environment.NewLine + @"</font>";

        }

        private void btngerarPagina_Click(object sender, EventArgs e)
        {
            gerarpaginaempresas();
        }

        /*gerar a pagina de empresas */
        public void gerarpaginaempresas()
        {
            txtGeradordeEmpresas.Clear();

            string color = @"#58728a";
            string height = "300px";

            txtGeradordeEmpresas.Text = txtNomeEmpresa.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + "Telefone: "+txtTelefone.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + "Whatsapp: "+txtWats.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + txtEmail.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + txtEndereço.Text+", "+txtNumero.Text ;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + txtCaixaPostal.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + txtbairro.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + txtCidade.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + "CEP: "+txtCep.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + "";
            txtGeradordeEmpresas.Text += System.Environment.NewLine + @"[map lat="+txtLat.Text+" long=" +txtLog.Text+" height="+height+" color="+color+"]";
            txtGeradordeEmpresas.Text += System.Environment.NewLine + txtNomeEmpresa.Text;
            txtGeradordeEmpresas.Text += System.Environment.NewLine + "[/map]";

        }

        /*salvas as paginas html e pagina empresa e salva no outro txt as configs*/
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"html.txt", txtGeradorHtmlVisualizador.Text);
            System.IO.File.WriteAllText(@"pagina.txt", txtGeradordeEmpresas.Text);
            salvartodososcampostxt();
            System.IO.File.WriteAllText(txtNomeEmpresa.Text+".ini", txtdadosDosCampos.Text);
            //System.IO.File.WriteAllText(txtNomeEmpresa.Text+".ini", );



        }


        public void salvartodososcampostxt()
        {
            txtdadosDosCampos.Clear();

            txtdadosDosCampos.Text = txtNomeEmpresa.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtEndereço.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtNumero.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtCaixaPostal.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtbairro.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtCidade.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtCep.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtEmail.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtTelefone.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtWats.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtCor.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtLat.Text;
            txtdadosDosCampos.Text += System.Environment.NewLine + txtLog.Text;
        }


        /*junto do form loader ele carrega no combobox os aquivos em *.ini da pasta atual*/
        private void Form1_Load(object sender, EventArgs e)
        {

            carregaininacombobox();


        }

        /*carrega os campos para as suas respectivas txt*/
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            limpacampos();
            string nomearquivonacombobox;
            nomearquivonacombobox = cbArquivosConfigs.SelectedItem.ToString();
            //MessageBox.Show(nomearquivonacombobox);

            string[] lines = System.IO.File.ReadAllLines(nomearquivonacombobox);

            txtNomeEmpresa.Text = lines[0];
            txtEndereço.Text = lines[1];
            txtNumero.Text = lines[2];
            txtCaixaPostal.Text = lines[3];
            txtbairro.Text = lines[4];
            txtCidade.Text = lines[5];
            txtCep.Text = lines[6];
            txtEmail.Text = lines[7];
            txtTelefone.Text = lines[8];
            txtWats.Text = lines[9];
            txtCor.Text = lines[10];
            txtLat.Text = lines[11];
            txtLog.Text = lines[12];

        }



        /*limpa os campos da txt*/
        public void limpacampos()
        {
            txtNomeEmpresa.Text = "";
            txtEndereço.Text = "";
            txtNumero.Text = "";
            txtCaixaPostal.Text = "";
            txtbairro.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtWats.Text = "";
            txtCor.Text = "";
            txtLat.Text = "";
            txtLog.Text = "";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            carregaininacombobox();
        }


        /*carrega todas as inis para o combobox*/
        public void carregaininacombobox()
        {
            cbArquivosConfigs.Items.Clear();

            string diretorio = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(diretorio);

            FileInfo[] rgFiles = di.GetFiles("*.ini");

            foreach (FileInfo arq in rgFiles)
            {
                cbArquivosConfigs.Items.Add(arq.Name);
            }
        }
    }
}
