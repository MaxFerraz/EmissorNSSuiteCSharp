using System.ComponentModel;

namespace EmissorNSSuiteCSharp.Models.Enums
{
    public class EnumOrigModel
    {
        public enum Orig
        {
            [Description("0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;")]
            Nacional3458 = 0,
            [Description("1 - Estrangeira - Importação direta, exceto a indicada no código 6;")]
            EstrangeiraExc6 = 1,
            [Description("2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;")]
            EstrangeiraExc7 = 2,
            [Description("3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% e inferior ou igual a 70%;")]
            NacionalSup40Inf70 = 3,
            [Description("4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;")]
            NacionalAjustes = 4,
            [Description("5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%;")]
            NacioanalInf40 = 5,
            [Description("6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;")]
            EstrangeiraImpDireta = 6,
            [Description("7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;")]
            EstrangeiraMercInt = 7,
            [Description("8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%;")]
            NacionalSup70 = 8
        };
    }
}
