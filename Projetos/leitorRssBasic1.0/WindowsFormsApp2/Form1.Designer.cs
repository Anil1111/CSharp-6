namespace WindowsFormsApp2
{
    partial class Formulario1
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
            this.btnCarrega = new System.Windows.Forms.Button();
            this.lbConteudo = new System.Windows.Forms.ListBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarrega
            // 
            this.btnCarrega.Location = new System.Drawing.Point(12, 12);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(280, 24);
            this.btnCarrega.TabIndex = 0;
            this.btnCarrega.Text = "Carregar";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // lbConteudo
            // 
            this.lbConteudo.FormattingEnabled = true;
            this.lbConteudo.Location = new System.Drawing.Point(12, 103);
            this.lbConteudo.Name = "lbConteudo";
            this.lbConteudo.Size = new System.Drawing.Size(280, 459);
            this.lbConteudo.TabIndex = 1;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(12, 53);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(280, 20);
            this.txtLink.TabIndex = 2;
            this.txtLink.Text = "http://feeds.feedburner.com/techulator/articles";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 574);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lbConteudo);
            this.Controls.Add(this.btnCarrega);
            this.Name = "Formulario1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.ListBox lbConteudo;
        private System.Windows.Forms.TextBox txtLink;
    }
}

