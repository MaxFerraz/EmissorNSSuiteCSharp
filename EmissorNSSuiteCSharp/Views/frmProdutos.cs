using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmissorNSSuiteCSharp.Banco;
using EmissorNSSuiteCSharp.Models;
using EmissorNSSuiteCSharp.Controllers;

namespace EmissorNSSuiteCSharp.Views
{
    public partial class frmProdutos : Form
    {
        CadProdutos cadProd = new CadProdutos();
        CadProdutoscontroller cadProdControl = new CadProdutoscontroller();
        GravaLog gravaLogAqui = new GravaLog();

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            //ConexaoBanco banco = new ConexaoBanco();
            // banco.Conectar();

            if (ValidaCadastroGeral() == false)
            {
                return;
            }
            cadProd.CodProd = Convert.ToInt32(txtCodigo.Text);
            cadProd.Codigo_barras = txtCodigoBarras.Text;
            cadProd.Descricao = txtDescricao.Text;
            cadProd.Cfop = txtCFOP.Text;
            cadProd.Ncm = txtNCM.Text;
            cadProd.Cest = txtCEST.Text;
            cadProd.ValorAprox = txtValorAprox.Text;
            cadProd.ISat = "A";
            cadProd.Unid_comerc = txtUndMedida.Text;
            cadProd.Custo_unit = txtCustoUnit.Text;
            cadProd.Quant = txtQuantidade.Text;
            cadProd.Cod_Origem = 0;
            cadProdControl.Inserir(cadProd);
            MessageBox.Show("Produto Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //LimparCadProdutos();
        }





        public Boolean ValidaCadastroGeral()
        {
            try
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Informe o Codigo do Produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                gravaLogAqui.grava("Erro no Metodo ValidaCadastroGeral : " + ex);
                throw new Exception("Erro: " + ex.Message);
            }
        }
    }
}
