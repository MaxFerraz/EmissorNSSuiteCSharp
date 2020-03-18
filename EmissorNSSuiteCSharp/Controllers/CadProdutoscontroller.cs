using EmissorNSSuiteCSharp.Banco;
using EmissorNSSuiteCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Controllers
{
    class CadProdutoscontroller
    {
        public string comandoSql = "";
        ConexaoBanco banco = new ConexaoBanco();
        CadProdutos cadprod = new CadProdutos();
        GravaLog gravaLogAqui = new GravaLog();

        public void Inserir(CadProdutos prod)
        {
            try
            {
                banco.Conectar();
                string comandoSql = "Insert into CAD_PRODUTOS(CODPRODUTO,CODIGO_BARRAS,DESCRICAO,CFOP,NCM,CEST,VALOR_APROX,ISAT,UNID_COMERC,CUSTO_UNIT,QUANT,ORIGEM) values('" + prod.CodProd + "','" + prod.Codigo_barras + "','" + prod.Descricao + 
                  "','" + prod.Cfop + "','" + prod.Ncm + "','" + prod.Cest + "','" + prod.ValorAprox + "','" + prod.Unid_comerc + "','" + prod.Custo_unit + "','" + prod.Quant + "','" + prod.Cod_Origem + "')";
                banco.EnviandoBanco(comandoSql);
            }
            catch (Exception ex)
            {
                gravaLogAqui.grava("Erro no Método Inserir() - tabela CAD_PRODUTOS - : " + ex);
                throw new Exception("Erro ao tentar Cadastrar o Produtos: " + ex.Message);
            }
        }



    }
}
