namespace EmissorNSSuiteCSharp.Views
{
    partial class frmPrincipal
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
            this.btnEmissaoNFCe = new System.Windows.Forms.Button();
            this.btnEmissaoSAT = new System.Windows.Forms.Button();
            this.btnEmissaoNFe = new System.Windows.Forms.Button();
            this.btnEmissaoCTe = new System.Windows.Forms.Button();
            this.btnEmissaoMDFe = new System.Windows.Forms.Button();
            this.btnEmissaoBPe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmissaoNFCe
            // 
            this.btnEmissaoNFCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmissaoNFCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmissaoNFCe.Location = new System.Drawing.Point(26, 41);
            this.btnEmissaoNFCe.Name = "btnEmissaoNFCe";
            this.btnEmissaoNFCe.Size = new System.Drawing.Size(214, 107);
            this.btnEmissaoNFCe.TabIndex = 0;
            this.btnEmissaoNFCe.Text = "Emissão NFC-e";
            this.btnEmissaoNFCe.UseVisualStyleBackColor = true;
            this.btnEmissaoNFCe.Click += new System.EventHandler(this.btnEmissaoNFCe_Click);
            // 
            // btnEmissaoSAT
            // 
            this.btnEmissaoSAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmissaoSAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmissaoSAT.Location = new System.Drawing.Point(284, 41);
            this.btnEmissaoSAT.Name = "btnEmissaoSAT";
            this.btnEmissaoSAT.Size = new System.Drawing.Size(214, 107);
            this.btnEmissaoSAT.TabIndex = 1;
            this.btnEmissaoSAT.Text = "Emissão SAT";
            this.btnEmissaoSAT.UseVisualStyleBackColor = true;
            this.btnEmissaoSAT.Click += new System.EventHandler(this.btnEmissaoSAT_Click);
            // 
            // btnEmissaoNFe
            // 
            this.btnEmissaoNFe.Enabled = false;
            this.btnEmissaoNFe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmissaoNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmissaoNFe.Location = new System.Drawing.Point(541, 41);
            this.btnEmissaoNFe.Name = "btnEmissaoNFe";
            this.btnEmissaoNFe.Size = new System.Drawing.Size(214, 107);
            this.btnEmissaoNFe.TabIndex = 2;
            this.btnEmissaoNFe.Text = "Emissão NF-e";
            this.btnEmissaoNFe.UseVisualStyleBackColor = true;
            this.btnEmissaoNFe.Click += new System.EventHandler(this.btnEmissaoNFe_Click);
            // 
            // btnEmissaoCTe
            // 
            this.btnEmissaoCTe.Enabled = false;
            this.btnEmissaoCTe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmissaoCTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmissaoCTe.Location = new System.Drawing.Point(284, 208);
            this.btnEmissaoCTe.Name = "btnEmissaoCTe";
            this.btnEmissaoCTe.Size = new System.Drawing.Size(214, 107);
            this.btnEmissaoCTe.TabIndex = 3;
            this.btnEmissaoCTe.Text = "Emissão CT-e";
            this.btnEmissaoCTe.UseVisualStyleBackColor = true;
            this.btnEmissaoCTe.Click += new System.EventHandler(this.btnEmissaoCTe_Click);
            // 
            // btnEmissaoMDFe
            // 
            this.btnEmissaoMDFe.Enabled = false;
            this.btnEmissaoMDFe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmissaoMDFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmissaoMDFe.Location = new System.Drawing.Point(541, 208);
            this.btnEmissaoMDFe.Name = "btnEmissaoMDFe";
            this.btnEmissaoMDFe.Size = new System.Drawing.Size(214, 107);
            this.btnEmissaoMDFe.TabIndex = 4;
            this.btnEmissaoMDFe.Text = "Emissão MDF-e";
            this.btnEmissaoMDFe.UseVisualStyleBackColor = true;
            this.btnEmissaoMDFe.Click += new System.EventHandler(this.btnEmissaoMDFe_Click);
            // 
            // btnEmissaoBPe
            // 
            this.btnEmissaoBPe.Enabled = false;
            this.btnEmissaoBPe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmissaoBPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmissaoBPe.Location = new System.Drawing.Point(26, 208);
            this.btnEmissaoBPe.Name = "btnEmissaoBPe";
            this.btnEmissaoBPe.Size = new System.Drawing.Size(214, 107);
            this.btnEmissaoBPe.TabIndex = 6;
            this.btnEmissaoBPe.Text = "Emissão BP-e";
            this.btnEmissaoBPe.UseVisualStyleBackColor = true;
            this.btnEmissaoBPe.Click += new System.EventHandler(this.btnEmissaoBPe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.btnEmissaoBPe);
            this.Controls.Add(this.btnEmissaoMDFe);
            this.Controls.Add(this.btnEmissaoCTe);
            this.Controls.Add(this.btnEmissaoNFe);
            this.Controls.Add(this.btnEmissaoSAT);
            this.Controls.Add(this.btnEmissaoNFCe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmissaoNFCe;
        private System.Windows.Forms.Button btnEmissaoSAT;
        private System.Windows.Forms.Button btnEmissaoNFe;
        private System.Windows.Forms.Button btnEmissaoCTe;
        private System.Windows.Forms.Button btnEmissaoMDFe;
        private System.Windows.Forms.Button btnEmissaoBPe;
    }
}

