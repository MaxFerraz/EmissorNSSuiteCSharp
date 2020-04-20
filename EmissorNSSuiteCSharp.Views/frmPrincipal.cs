using System;
using System.Threading;
using System.Windows.Forms;

namespace EmissorNSSuiteCSharp.Views
{ 
    public partial class frmPrincipal : Form
    {
        Thread thread;
        public frmPrincipal()
        {
            InitializeComponent();
            btnEmissaoCTe.Enabled = false;
            btnEmissaoMDFe.Enabled = false;
            btnEmissaoNFe.Enabled = false;
            btnEmissaoNFCe.Enabled = false;
        }

        private void btnEmissaoSAT_Click(object sender, EventArgs e)
        {
            Close();
            thread = new Thread(() => Application.Run(new frmEmissaoSAT()));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void btnEmissaoNFCe_Click(object sender, EventArgs e)
        {
            Close();
            thread = new Thread(() => Application.Run(new frmEmissaoNFCe()));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnEmissaoCTe_Click(object sender, EventArgs e)
        {
            Close();
           // thread = new Thread(() => Application.Run(new frmEmissaoCTe()));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnEmissaoMDFe_Click(object sender, EventArgs e)
        {
            Close();
           // thread = new Thread(() => Application.Run(new frmEmissaoMDFe()));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnEmissaoNFe_Click(object sender, EventArgs e)
        {
            Close();
            //thread = new Thread(() => Application.Run(new frmEmissaoNFe()));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnEmissaoBPe_Click(object sender, EventArgs e)
        {
            Close();
            //thread = new Thread(() => Application.Run(new frmEmissaoBPe()));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
