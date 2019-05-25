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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenosQuantiadesenhasgeradas = new System.Windows.Forms.Button();
            this.btnmaisQuantiadesenhasgeradas = new System.Windows.Forms.Button();
            this.txtQuantiadeSenhasgeradas = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaidasenha
            // 
            this.txtSaidasenha.Location = new System.Drawing.Point(12, 26);
            this.txtSaidasenha.Multiline = true;
            this.txtSaidasenha.Name = "txtSaidasenha";
            this.txtSaidasenha.Size = new System.Drawing.Size(240, 92);
            this.txtSaidasenha.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(12, 229);
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
            this.chkNumeros.Location = new System.Drawing.Point(12, 206);
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
            this.chkLetrasminusculas.Location = new System.Drawing.Point(12, 261);
            this.chkLetrasminusculas.Name = "chkLetrasminusculas";
            this.chkLetrasminusculas.Size = new System.Drawing.Size(110, 17);
            this.chkLetrasminusculas.TabIndex = 5;
            this.chkLetrasminusculas.Text = "Letras minusculas";
            this.chkLetrasminusculas.UseVisualStyleBackColor = true;
            // 
            // txtLetrasminusculas
            // 
            this.txtLetrasminusculas.Location = new System.Drawing.Point(12, 284);
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
            this.chkLetrasmaiusculas.Location = new System.Drawing.Point(12, 316);
            this.chkLetrasmaiusculas.Name = "chkLetrasmaiusculas";
            this.chkLetrasmaiusculas.Size = new System.Drawing.Size(110, 17);
            this.chkLetrasmaiusculas.TabIndex = 7;
            this.chkLetrasmaiusculas.Text = "Letras maiusculas";
            this.chkLetrasmaiusculas.UseVisualStyleBackColor = true;
            // 
            // txtLetrasmaiusculas
            // 
            this.txtLetrasmaiusculas.Location = new System.Drawing.Point(12, 339);
            this.txtLetrasmaiusculas.Name = "txtLetrasmaiusculas";
            this.txtLetrasmaiusculas.ReadOnly = true;
            this.txtLetrasmaiusculas.Size = new System.Drawing.Size(240, 20);
            this.txtLetrasmaiusculas.TabIndex = 6;
            this.txtLetrasmaiusculas.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // chkCaracteresespeciais
            // 
            this.chkCaracteresespeciais.AutoSize = true;
            this.chkCaracteresespeciais.Location = new System.Drawing.Point(12, 370);
            this.chkCaracteresespeciais.Name = "chkCaracteresespeciais";
            this.chkCaracteresespeciais.Size = new System.Drawing.Size(124, 17);
            this.chkCaracteresespeciais.TabIndex = 9;
            this.chkCaracteresespeciais.Text = "Caracteres especiais";
            this.chkCaracteresespeciais.UseVisualStyleBackColor = true;
            // 
            // txtCaracteresespeciais
            // 
            this.txtCaracteresespeciais.Location = new System.Drawing.Point(12, 393);
            this.txtCaracteresespeciais.Name = "txtCaracteresespeciais";
            this.txtCaracteresespeciais.Size = new System.Drawing.Size(240, 20);
            this.txtCaracteresespeciais.TabIndex = 8;
            // 
            // txtTamanhosenha
            // 
            this.txtTamanhosenha.Location = new System.Drawing.Point(41, 170);
            this.txtTamanhosenha.Name = "txtTamanhosenha";
            this.txtTamanhosenha.Size = new System.Drawing.Size(39, 20);
            this.txtTamanhosenha.TabIndex = 10;
            this.txtTamanhosenha.Text = "25";
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(86, 170);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(23, 20);
            this.btnMais.TabIndex = 11;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.BtnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(12, 169);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(23, 20);
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 124);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(76, 28);
            this.btnGerar.TabIndex = 13;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 28);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(176, 124);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 28);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tamanho da senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quantas senhas para gerar";
            // 
            // btnMenosQuantiadesenhasgeradas
            // 
            this.btnMenosQuantiadesenhasgeradas.Location = new System.Drawing.Point(147, 171);
            this.btnMenosQuantiadesenhasgeradas.Name = "btnMenosQuantiadesenhasgeradas";
            this.btnMenosQuantiadesenhasgeradas.Size = new System.Drawing.Size(23, 20);
            this.btnMenosQuantiadesenhasgeradas.TabIndex = 20;
            this.btnMenosQuantiadesenhasgeradas.Text = "-";
            this.btnMenosQuantiadesenhasgeradas.UseVisualStyleBackColor = true;
            this.btnMenosQuantiadesenhasgeradas.Click += new System.EventHandler(this.BtnMenosQuantiadesenhasgeradas_Click);
            // 
            // btnmaisQuantiadesenhasgeradas
            // 
            this.btnmaisQuantiadesenhasgeradas.Location = new System.Drawing.Point(221, 171);
            this.btnmaisQuantiadesenhasgeradas.Name = "btnmaisQuantiadesenhasgeradas";
            this.btnmaisQuantiadesenhasgeradas.Size = new System.Drawing.Size(23, 20);
            this.btnmaisQuantiadesenhasgeradas.TabIndex = 19;
            this.btnmaisQuantiadesenhasgeradas.Text = "+";
            this.btnmaisQuantiadesenhasgeradas.UseVisualStyleBackColor = true;
            this.btnmaisQuantiadesenhasgeradas.Click += new System.EventHandler(this.BtnmaisQuantiadesenhasgeradas_Click);
            // 
            // txtQuantiadeSenhasgeradas
            // 
            this.txtQuantiadeSenhasgeradas.Location = new System.Drawing.Point(176, 171);
            this.txtQuantiadeSenhasgeradas.Name = "txtQuantiadeSenhasgeradas";
            this.txtQuantiadeSenhasgeradas.ReadOnly = true;
            this.txtQuantiadeSenhasgeradas.Size = new System.Drawing.Size(39, 20);
            this.txtQuantiadeSenhasgeradas.TabIndex = 18;
            this.txtQuantiadeSenhasgeradas.Text = "1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 426);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 28);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // GeradorSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 466);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenosQuantiadesenhasgeradas);
            this.Controls.Add(this.btnmaisQuantiadesenhasgeradas);
            this.Controls.Add(this.txtQuantiadeSenhasgeradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMenosQuantiadesenhasgeradas;
        private System.Windows.Forms.Button btnmaisQuantiadesenhasgeradas;
        private System.Windows.Forms.TextBox txtQuantiadeSenhasgeradas;
        private System.Windows.Forms.Button btnSalvar;
    }
}

