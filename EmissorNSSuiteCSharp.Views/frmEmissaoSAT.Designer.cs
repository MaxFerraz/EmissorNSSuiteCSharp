namespace EmissorNSSuiteCSharp.Views
{
    partial class frmEmissaoSAT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmissaoSAT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCadProds = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_LimparSAT = new System.Windows.Forms.Button();
            this.Btn_ExcluirProd = new System.Windows.Forms.Button();
            this.Btn_Finalizar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(75, 42);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(674, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(674, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 180);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCadProds);
            this.groupBox2.Controls.Add(this.Btn_Sair);
            this.groupBox2.Controls.Add(this.Btn_LimparSAT);
            this.groupBox2.Controls.Add(this.Btn_ExcluirProd);
            this.groupBox2.Controls.Add(this.Btn_Finalizar);
            this.groupBox2.Location = new System.Drawing.Point(12, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnCadProds
            // 
            this.btnCadProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProds.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProds.Image")));
            this.btnCadProds.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCadProds.Location = new System.Drawing.Point(504, 24);
            this.btnCadProds.Name = "btnCadProds";
            this.btnCadProds.Size = new System.Drawing.Size(164, 42);
            this.btnCadProds.TabIndex = 21;
            this.btnCadProds.Text = "&Cad. Produtos";
            this.btnCadProds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadProds.UseVisualStyleBackColor = true;
            this.btnCadProds.Click += new System.EventHandler(this.btnCadProds_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sair.Image")));
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(674, 24);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(91, 42);
            this.Btn_Sair.TabIndex = 20;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_LimparSAT
            // 
            this.Btn_LimparSAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LimparSAT.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LimparSAT.Image")));
            this.Btn_LimparSAT.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_LimparSAT.Location = new System.Drawing.Point(388, 24);
            this.Btn_LimparSAT.Name = "Btn_LimparSAT";
            this.Btn_LimparSAT.Size = new System.Drawing.Size(110, 42);
            this.Btn_LimparSAT.TabIndex = 19;
            this.Btn_LimparSAT.Text = "&Limpar";
            this.Btn_LimparSAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_LimparSAT.UseVisualStyleBackColor = true;
            // 
            // Btn_ExcluirProd
            // 
            this.Btn_ExcluirProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirProd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ExcluirProd.Image")));
            this.Btn_ExcluirProd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_ExcluirProd.Location = new System.Drawing.Point(217, 24);
            this.Btn_ExcluirProd.Name = "Btn_ExcluirProd";
            this.Btn_ExcluirProd.Size = new System.Drawing.Size(165, 42);
            this.Btn_ExcluirProd.TabIndex = 18;
            this.Btn_ExcluirProd.Text = "&Excluir Produto";
            this.Btn_ExcluirProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirProd.UseVisualStyleBackColor = true;
            this.Btn_ExcluirProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Finalizar.Image")));
            this.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Finalizar.Location = new System.Drawing.Point(6, 19);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Size = new System.Drawing.Size(182, 53);
            this.Btn_Finalizar.TabIndex = 17;
            this.Btn_Finalizar.Text = "&Finalizar Venda";
            this.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Finalizar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(779, 180);
            this.dataGridView2.TabIndex = 4;
            // 
            // frmEmissaoSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmissaoSAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Emissão SAT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button Btn_Sair;
        internal System.Windows.Forms.Button Btn_LimparSAT;
        internal System.Windows.Forms.Button Btn_ExcluirProd;
        internal System.Windows.Forms.Button Btn_Finalizar;
        private System.Windows.Forms.DataGridView dataGridView2;
        internal System.Windows.Forms.Button btnCadProds;
    }
}