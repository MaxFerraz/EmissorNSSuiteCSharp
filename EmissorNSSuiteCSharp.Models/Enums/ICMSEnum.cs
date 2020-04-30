using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EmissorNSSuiteCSharp.Models.Enums
{
    public class ICMSEnum
    {
        public enum CST
        {
            [Description("00 – Tributada integralmente")]
            TributadaIntegralmente = 00,
            [Description("20 - Com redução de base de cálculo")]
            ComReducaoBC = 20,
            [Description("40 - Isenta")]
            Isenta = 40,
            [Description("41 - Não tributada")]
            NaoTributada = 41,
            [Description("60 - ICMS cobrado anteriormente por substituição tributária")]
            CobradoST = 60,
            [Description("90 - Outros")]
            Outros = 90
        };
        public enum CSON
        { 
            [Description("102- Tributada pelo Simples Nacional sem permissão de crédito;")]
            SNnCred = 102,
            [Description("300 – Imune;")]
            Imune = 300,
            [Description("400 – Não tributada;")]
            nTributada = 400,
            [Description("500 – ICMS cobrado anteriormente por substituição tributária (substituído) ou por antecipação;")]
            CobradoST = 500,                
            [Description("900 - Outros.")]
            Outros = 900
        };
    }
}
