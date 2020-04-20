using System;
using System.Windows.Forms;

namespace EmissorNSSuiteCSharp.Views
{
    public partial class frmEmissaoSAT : Form
    {
        public frmEmissaoSAT()
        {
            InitializeComponent();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadProds_Click(object sender, EventArgs e)
        {
            Hide();
            frmProdutos frmProdutos = new frmProdutos(ProjectWithProducts.CFe, this);
            frmProdutos.Show();
        }
    }
}
