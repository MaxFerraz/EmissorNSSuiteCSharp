using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Models
{
    class CadProdutos
    {
        private int codProd;
        private string codigo_barras;
        private string descricao;
        private string cfop;
        private string ncm;
        private string cest;
        private string valorAprox;
        private string iSat;
        private string unid_comerc;
        private string custo_unit;
        private string quant;
        private int? cod_origem;




        //Get and Set
        public int CodProd
        {
            get
            {
                return codProd;
            }

            set
            {
                codProd = value;
            }
        }

        public string Codigo_barras
        {
            get
            {
                return codigo_barras;
            }

            set
            {
                codigo_barras = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Cfop
        {
            get
            {
                return cfop;
            }

            set
            {
                cfop = value;
            }
        }

        public string Ncm
        {
            get
            {
                return ncm;
            }

            set
            {
                ncm = value;
            }
        }

        public string Cest
        {
            get
            {
                return cest;
            }

            set
            {
                cest = value;
            }
        }

        public string ValorAprox
        {
            get
            {
                return valorAprox;
            }

            set
            {
                valorAprox = value;
            }
        }

        public string ISat
        {
            get
            {
                return iSat;
            }

            set
            {
                iSat = value;
            }
        }

        public string Unid_comerc
        {
            get
            {
                return unid_comerc;
            }

            set
            {
                unid_comerc = value;
            }
        }

        public string Custo_unit
        {
            get
            {
                return custo_unit;
            }

            set
            {
                custo_unit = value;
            }
        }

        public string Quant
        {
            get
            {
                return quant;
            }

            set
            {
                quant = value;
            }
        }

        public int? Cod_Origem
        {
            get
            {
                return cod_origem;
            }

            set
            {
                cod_origem = value;
            }
        }


    }



}
