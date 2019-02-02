namespace abriraplicativo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoDoArquivo = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminhoFechaServer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrirAutomatico = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.txtHoraTimer = new System.Windows.Forms.TextBox();
            this.txtHoraServer = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho do arquivo Servidor";
            // 
            // txtCaminhoDoArquivo
            // 
            this.txtCaminhoDoArquivo.Location = new System.Drawing.Point(15, 25);
            this.txtCaminhoDoArquivo.Name = "txtCaminhoDoArquivo";
            this.txtCaminhoDoArquivo.Size = new System.Drawing.Size(341, 20);
            this.txtCaminhoDoArquivo.TabIndex = 1;
            this.txtCaminhoDoArquivo.Text = "C:\\timer\\a.bat";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(15, 51);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(12, 119);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caminho do arquivo Fechar Servidor";
            // 
            // txtCaminhoFechaServer
            // 
            this.txtCaminhoFechaServer.Location = new System.Drawing.Point(12, 93);
            this.txtCaminhoFechaServer.Name = "txtCaminhoFechaServer";
            this.txtCaminhoFechaServer.Size = new System.Drawing.Size(341, 20);
            this.txtCaminhoFechaServer.TabIndex = 5;
            this.txtCaminhoFechaServer.Text = "C:\\timer\\closeServer.bat";
            // 
            // timer1
            // 
            this.timer1.Interval = 35000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horario de Fechar o server";
            // 
            // btnAbrirAutomatico
            // 
            this.btnAbrirAutomatico.Location = new System.Drawing.Point(12, 295);
            this.btnAbrirAutomatico.Name = "btnAbrirAutomatico";
            this.btnAbrirAutomatico.Size = new System.Drawing.Size(130, 23);
            this.btnAbrirAutomatico.TabIndex = 11;
            this.btnAbrirAutomatico.Text = "Abrir Automatico";
            this.btnAbrirAutomatico.UseVisualStyleBackColor = true;
            this.btnAbrirAutomatico.Click += new System.EventHandler(this.btnAbrirAutomatico_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(12, 324);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(130, 23);
            this.btnParar.TabIndex = 12;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnFecharAutomatico_Click);
            // 
            // txtHoraTimer
            // 
            this.txtHoraTimer.Location = new System.Drawing.Point(148, 298);
            this.txtHoraTimer.Name = "txtHoraTimer";
            this.txtHoraTimer.ReadOnly = true;
            this.txtHoraTimer.Size = new System.Drawing.Size(58, 20);
            this.txtHoraTimer.TabIndex = 13;
            this.txtHoraTimer.Text = "0";
            // 
            // txtHoraServer
            // 
            this.txtHoraServer.Location = new System.Drawing.Point(15, 170);
            this.txtHoraServer.Multiline = true;
            this.txtHoraServer.Name = "txtHoraServer";
            this.txtHoraServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHoraServer.Size = new System.Drawing.Size(127, 119);
            this.txtHoraServer.TabIndex = 15;
            this.txtHoraServer.Text = "4:00\r\n16:00";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(148, 134);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(156, 155);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 16;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 361);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtHoraServer);
            this.Controls.Add(this.txtHoraTimer);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnAbrirAutomatico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCaminhoFechaServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtCaminhoDoArquivo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Console Automatico NRP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoDoArquivo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminhoFechaServer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbrirAutomatico;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.TextBox txtHoraTimer;
        private System.Windows.Forms.TextBox txtHoraServer;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

