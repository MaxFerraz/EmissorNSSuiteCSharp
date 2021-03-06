﻿using EmissorNSSuiteCSharp.Controllers;
using EmissorNSSuiteCSharp.Controllers.Exceptions;
using EmissorNSSuiteCSharp.Controllers.Extensions;
using EmissorNSSuiteCSharp.Entities;
using EmissorNSSuiteCSharp.Models;
using EmissorNSSuiteCSharp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmissorNSSuiteCSharp.Views
{
    public enum ProjectWithProducts { NFCe, NFe, CFe }
    
    public partial class frmProdutos : Form
    {
        private ProjectWithProducts project;
        private Form form;
        private EnumsGenericController enumsGenericController;
        
        public frmProdutos(ProjectWithProducts project, Form form)
        {
            this.form = form;
            this.project = project;
            this.enumsGenericController = new EnumsGenericController();
            InitializeComponent();
        }
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ClearTextBoxs(this.Controls);
            switch (project)
            {
                case ProjectWithProducts.CFe:
                    {
                        tpIIProd.Hide();
                        tpIPIProd.Hide();

                        //Informações Produtos
                        cbIndRegra.Enabled = true;
                        gbICMSST.Enabled = false;
                        cbmodBC.Enabled = false;
                        txtpRedBC.Enabled = false;
                        txtpFCP.Enabled = false;
                        txtpCredSN.Enabled = false;
                        txtvCredICMSSN.Enabled = false;
                        txtmotDeson.Enabled = false;

                        //Informações ICMS RN
                        cbICMSCST.Items.AddRange(new object[]
                        {
                            ICMSEnum.CST.TributadaIntegralmente.GetDescription(),
                            ICMSEnum.CST.ComReducaoBC.GetDescription(),
                            ICMSEnum.CST.Isenta.GetDescription(),
                            ICMSEnum.CST.NaoTributada.GetDescription(),
                            ICMSEnum.CST.CobradoST.GetDescription(),
                            ICMSEnum.CST.Outros.GetDescription()
                        });

                        //Informações ICMS SN
                        cbICMSCSOSN.Items.AddRange(new object[]
                        {
                            ICMSEnum.CSON.SNnCred.GetDescription(),
                            ICMSEnum.CSON.Imune.GetDescription(),
                            ICMSEnum.CSON.nTributada.GetDescription(),
                            ICMSEnum.CSON.CobradoST.GetDescription(),
                            ICMSEnum.CSON.Outros.GetDescription()
                        });
                        
                        break;
                    }
                case ProjectWithProducts.NFCe:
                    {
                        break;
                    }
                case ProjectWithProducts.NFe:
                    {
                        break;
                    }
            }
        }

        private async void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Btn_Alterar.Enabled = false;
            Btn_Cadastrar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Voltar.Enabled = false;

            try
            {                
                DialogResult dialogResult = MessageBox.Show("Dejesa continuar a operação de Cadastro de Produto?\n Pois o mesmo será registrado no Banco de Dados", "Confirmação de Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                
                if (dialogResult == DialogResult.No)
                    return;

                var product = await ValidateProductAsync();

                Dtgv_ProdsInDB.DataSource = await Task.Run(() => product.Register());

                MessageBox.Show($"Cadastro do Produto '{txtDescricao}' feito com sucesso!", "Sucesso ao Cadastrar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (RequiredFieldException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Cadatrar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Btn_Alterar.Enabled = true;
            Btn_Cadastrar.Enabled = true;
            Btn_Excluir.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Voltar.Enabled = true;
        }

        private Task<Product> ValidadeInfProduct()
        {
            return Task.Run(() =>
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                    throw new RequiredFieldException(Lbl_cProd.Text);
                if (string.IsNullOrEmpty(txtDescricao.Text))
                    throw new RequiredFieldException(Lbl_xProd.Text);
                if (string.IsNullOrEmpty(txtCFOP.Text))
                    throw new RequiredFieldException(Lbl_CFOP.Text);
                if (string.IsNullOrEmpty(txtUndMedida.Text))
                    throw new RequiredFieldException(Lbl_uCom.Text);
                if (string.IsNullOrEmpty(txtQuantidade.Text))
                    throw new RequiredFieldException(Lbl_Quantity.Text);
                if (string.IsNullOrEmpty(txtCustoUnit.Text))
                    throw new RequiredFieldException(Lbl_vUnCom.Text);
                if (string.IsNullOrEmpty(txtNCM.Text))
                    throw new RequiredFieldException(Lbl_NCM.Text);
                if (string.IsNullOrEmpty(txtCEST.Text))
                    throw new RequiredFieldException(Lbl_CEST.Text);

                var p = new Product()
                {
                    CProd = txtCodigo.Text,
                    XProd = txtDescricao.Text,
                    Quantity = int.Parse(txtQuantidade.Text),
                    NCM = txtNCM.Text,
                    CFOP = txtCFOP.Text,
                    CEST = txtCEST.Text,
                    UCom = txtUndMedida.Text,
                    VUnCom = double.Parse(txtCustoUnit.Text),                  
                    VTotTrib = string.IsNullOrEmpty(txtValorAprox.Text) ? null : txtValorAprox.Text
                };

                switch (project)
                {
                    case ProjectWithProducts.CFe:
                        {
                            p.CEAN = txtCodigoBarras.Text;
                            if (string.IsNullOrEmpty(cbIndRegra.Text))
                                throw new RequiredFieldException(Lbl_IndRegra.Text);
                            p.IndRegra = cbIndRegra.Text;
                            break;
                        }
                    case ProjectWithProducts.NFCe:
                    case ProjectWithProducts.NFe:
                        {
                            p.CEAN = string.IsNullOrEmpty(txtCodigoBarras.Text) ? "SEM GTIN" : txtCodigoBarras.Text;
                            p.CEANTrib = p.CEAN;
                            break;
                        }
                }
                return p;
            });
        }
        private Task<ICMS> ValidadeICMS()
        {
            switch (project)
            {

            }
            return null;
        }
        private Task<PIS> ValidadePIS()
        {
            switch (project)
            {

            }
            return null;
        }
        private Task<COFINS> ValidadeCOFINS()
        {
            switch (project)
            {

            }
            return null;
        }
        private Task<IPI> ValidadeIPI()
        {
            switch (project)
            {

            }
            return null;
        }
        private Task<ISSQN> ValidadeISSQN()
        {
            switch (project)
            {

            }
            return null;
        }
        private async Task<Product> ValidateProductAsync()
        {
            var PISTask = ValidadePIS();
            var COFINSTask = ValidadeCOFINS();
            var IPITask = ValidadeIPI();
            var ICMSTask = ValidadeICMS();
            var ISSQNTask = ValidadeISSQN();
            var ProductTask = ValidadeInfProduct();

            await Task.WhenAll(ProductTask, ICMSTask, PISTask, COFINSTask, IPITask, ISSQNTask);

            var product = await ProductTask;
            product.PIS = await PISTask;
            product.COFINS = await COFINSTask;
            product.ICMS = await ICMSTask;
            product.ISSQN = await ISSQNTask;
            product.IPI = await IPITask;

            return product;
        }

        private void ClearTextBoxs(Control.ControlCollection controles)
        {    
            foreach (Control ctrl in controles)
            {
                
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            ClearTextBoxs(this.Controls);
        }

        private void VoltarEmissor()
        {
            Hide();
            form.Show();
        }
        private void frmProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            VoltarEmissor();
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarEmissor();
        }
        private void Dtgv_ProdsInDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
