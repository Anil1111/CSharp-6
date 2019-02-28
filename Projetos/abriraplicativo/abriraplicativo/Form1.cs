using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace abriraplicativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string caminhoArquivo;
        public string[] lines;
        public string[] hora;

        private void btnAbrir_Click(object sender, EventArgs e)
        {




            //Interaction.Shell("ping", AppWinStyle.Hide);



            /*var proc1 = new ProcessStartInfo();
            string anyCommand;
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + "ping -t 8.8.8.8";
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
            */
           /* string strCmdText;
            strCmdText = "/C "+;
            Process.Start("CMD.exe", strCmdText);*/
            
            caminhoDoArquivo(txtCaminhoDoArquivo.Text); // abre o server o arquivo bat

        }




        public void caminhoDoArquivo(string caminho)
        {
/*
            Process notePad = new Process();
            notePad.StartInfo.FileName = caminho;
            //-notePad.StartInfo.Arguments = "mytextfile.txt";
            notePad.Start();
            notePad.Close();*/

            
            caminhoArquivo = "/C "+caminho;

            Process.Start("CMD.exe", caminhoArquivo);
            caminhoArquivo = "";
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            caminhoDoArquivo(txtCaminhoFechaServer.Text); // Fecha o server o arquivo bat
        }

        private void btnAbrirAutomatico_Click(object sender, EventArgs e)
        {

            timer1.Tick += new EventHandler(timer1_Tick);
           // timer1.Interval(5000);
            timer1.Start();
            btnAbrirAutomatico.Enabled = false;



        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sender == timer1)
            {
                //DateTime.Now.ToLongDateString();
                // MessageBox.Show(DateTime.Now.ToString("h:mm tt"));
                txtHoraTimer.Text = "";
                txtHoraTimer.Text = DateTime.Now.ToString("HH:mm");
                
            
                for (int aux = 0; aux < txtHoraServer.Lines.Length; aux++)
                {
                    if (txtHoraServer.Lines[aux].ToString() == txtHoraTimer.Text)
                    {
                       // MessageBox.Show("Passeia qui");
                        caminhoDoArquivo(txtCaminhoFechaServer.Text); // fechar
                        Thread.Sleep(2000);
                        caminhoDoArquivo(txtCaminhoDoArquivo.Text); // abrir
                        break;
                    }


                   
                 }


                    //MessageBox.Show(textBox1.Lines[aux].ToString());

            }
        }

        private void btnFecharAutomatico_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnAbrirAutomatico.Enabled = true;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lines = System.IO.File.ReadAllLines(@"C:\timer\config.txt");

            txtCaminhoDoArquivo.Text = lines[0];
            txtCaminhoFechaServer.Text = lines[1];


            txtHoraServer.Clear();
            hora = System.IO.File.ReadAllLines(@"C:\timer\confighora.txt");

            for (int aux = 0; aux < hora.Length; aux++)
            {
                txtHoraServer.AppendText(hora[aux] + Environment.NewLine);
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
