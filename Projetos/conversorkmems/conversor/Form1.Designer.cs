namespace conversor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtvelocidade = new System.Windows.Forms.TextBox();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverterKM = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConverterMS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidade";
            // 
            // txtvelocidade
            // 
            this.txtvelocidade.Location = new System.Drawing.Point(78, 12);
            this.txtvelocidade.Name = "txtvelocidade";
            this.txtvelocidade.Size = new System.Drawing.Size(118, 20);
            this.txtvelocidade.TabIndex = 1;
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(78, 38);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(118, 20);
            this.txtMetros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metro";
            // 
            // btnConverterKM
            // 
            this.btnConverterKM.Location = new System.Drawing.Point(202, 12);
            this.btnConverterKM.Name = "btnConverterKM";
            this.btnConverterKM.Size = new System.Drawing.Size(96, 22);
            this.btnConverterKM.TabIndex = 4;
            this.btnConverterKM.Text = "Converter KM";
            this.btnConverterKM.UseVisualStyleBackColor = true;
            this.btnConverterKM.Click += new System.EventHandler(this.btnConverterKM_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(304, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(73, 46);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConverterMS
            // 
            this.btnConverterMS.Location = new System.Drawing.Point(202, 36);
            this.btnConverterMS.Name = "btnConverterMS";
            this.btnConverterMS.Size = new System.Drawing.Size(96, 22);
            this.btnConverterMS.TabIndex = 7;
            this.btnConverterMS.Text = "Converter MS";
            this.btnConverterMS.UseVisualStyleBackColor = true;
            this.btnConverterMS.Click += new System.EventHandler(this.btnConverterMS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conversor de KM/H para MS/S\r\nFormula KM / 3,6\r\nFormula MS * 3,6\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 153);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConverterMS);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverterKM);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvelocidade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvelocidade;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConverterKM;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConverterMS;
        private System.Windows.Forms.Label label3;
    }
}

