namespace geradordesenhas
{
    partial class GeradorSenhas
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
            this.txtSaidasenha = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkLetrasminusculas = new System.Windows.Forms.CheckBox();
            this.txtLetrasminusculas = new System.Windows.Forms.TextBox();
            this.chkLetrasmaiusculas = new System.Windows.Forms.CheckBox();
            this.txtLetrasmaiusculas = new System.Windows.Forms.TextBox();
            this.chkCaracteresespeciais = new System.Windows.Forms.CheckBox();
            this.txtCaracteresespeciais = new System.Windows.Forms.TextBox();
            this.txtTamanhosenha = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaidasenha
            // 
            this.txtSaidasenha.Location = new System.Drawing.Point(12, 26);
            this.txtSaidasenha.Name = "txtSaidasenha";
            this.txtSaidasenha.Size = new System.Drawing.Size(240, 20);
            this.txtSaidasenha.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(12, 161);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ReadOnly = true;
            this.txtNumeros.Size = new System.Drawing.Size(240, 20);
            this.txtNumeros.TabIndex = 2;
            this.txtNumeros.Text = "1234567890";
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Checked = true;
            this.chkNumeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumeros.Location = new System.Drawing.Point(12, 138);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(68, 17);
            this.chkNumeros.TabIndex = 3;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkLetrasminusculas
            // 
            this.chkLetrasminusculas.AutoSize = true;
            this.chkLetrasminusculas.Checked = true;
            this.chkLetrasminusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetrasminusculas.Location = new System.Drawing.Point(12, 193);
            this.chkLetrasminusculas.Name = "chkLetrasminusculas";
            this.chkLetrasminusculas.Size = new System.Drawing.Size(110, 17);
            this.chkLetrasminusculas.TabIndex = 5;
            this.chkLetrasminusculas.Text = "Letras minusculas";
            this.chkLetrasminusculas.UseVisualStyleBackColor = true;
            // 
            // txtLetrasminusculas
            // 
            this.txtLetrasminusculas.Location = new System.Drawing.Point(12, 216);
            this.txtLetrasminusculas.Name = "txtLetrasminusculas";
            this.txtLetrasminusculas.ReadOnly = true;
            this.txtLetrasminusculas.Size = new System.Drawing.Size(240, 20);
            this.txtLetrasminusculas.TabIndex = 4;
            this.txtLetrasminusculas.Text = "abcdefghijklmnopqrstuvwxyz";
            // 
            // chkLetrasmaiusculas
            // 
            this.chkLetrasmaiusculas.AutoSize = true;
            this.chkLetrasmaiusculas.Checked = true;
            this.chkLetrasmaiusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetrasmaiusculas.Location = new System.Drawing.Point(12, 248);
            this.chkLetrasmaiusculas.Name = "chkLetrasmaiusculas";
            this.chkLetrasmaiusculas.Size = new System.Drawing.Size(110, 17);
            this.chkLetrasmaiusculas.TabIndex = 7;
            this.chkLetrasmaiusculas.Text = "Letras maiusculas";
            this.chkLetrasmaiusculas.UseVisualStyleBackColor = true;
            // 
            // txtLetrasmaiusculas
            // 
            this.txtLetrasmaiusculas.Location = new System.Drawing.Point(12, 271);
            this.txtLetrasmaiusculas.Name = "txtLetrasmaiusculas";
            this.txtLetrasmaiusculas.ReadOnly = true;
            this.txtLetrasmaiusculas.Size = new System.Drawing.Size(240, 20);
            this.txtLetrasmaiusculas.TabIndex = 6;
            this.txtLetrasmaiusculas.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // chkCaracteresespeciais
            // 
            this.chkCaracteresespeciais.AutoSize = true;
            this.chkCaracteresespeciais.Location = new System.Drawing.Point(12, 302);
            this.chkCaracteresespeciais.Name = "chkCaracteresespeciais";
            this.chkCaracteresespeciais.Size = new System.Drawing.Size(124, 17);
            this.chkCaracteresespeciais.TabIndex = 9;
            this.chkCaracteresespeciais.Text = "Caracteres especiais";
            this.chkCaracteresespeciais.UseVisualStyleBackColor = true;
            // 
            // txtCaracteresespeciais
            // 
            this.txtCaracteresespeciais.Location = new System.Drawing.Point(12, 325);
            this.txtCaracteresespeciais.Name = "txtCaracteresespeciais";
            this.txtCaracteresespeciais.Size = new System.Drawing.Size(240, 20);
            this.txtCaracteresespeciais.TabIndex = 8;
            // 
            // txtTamanhosenha
            // 
            this.txtTamanhosenha.Location = new System.Drawing.Point(12, 103);
            this.txtTamanhosenha.Name = "txtTamanhosenha";
            this.txtTamanhosenha.Size = new System.Drawing.Size(93, 20);
            this.txtTamanhosenha.TabIndex = 10;
            this.txtTamanhosenha.Text = "25";
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(113, 103);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(23, 20);
            this.btnMais.TabIndex = 11;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.BtnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(142, 103);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(23, 20);
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 52);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(76, 28);
            this.btnGerar.TabIndex = 13;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 52);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 28);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(176, 52);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 28);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // GeradorSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 368);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.txtTamanhosenha);
            this.Controls.Add(this.chkCaracteresespeciais);
            this.Controls.Add(this.txtCaracteresespeciais);
            this.Controls.Add(this.chkLetrasmaiusculas);
            this.Controls.Add(this.txtLetrasmaiusculas);
            this.Controls.Add(this.chkLetrasminusculas);
            this.Controls.Add(this.txtLetrasminusculas);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtSaidasenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GeradorSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaidasenha;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkLetrasminusculas;
        private System.Windows.Forms.TextBox txtLetrasminusculas;
        private System.Windows.Forms.CheckBox chkLetrasmaiusculas;
        private System.Windows.Forms.TextBox txtLetrasmaiusculas;
        private System.Windows.Forms.CheckBox chkCaracteresespeciais;
        private System.Windows.Forms.TextBox txtCaracteresespeciais;
        private System.Windows.Forms.TextBox txtTamanhosenha;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

