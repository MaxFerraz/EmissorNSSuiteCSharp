
namespace EmissorNSSuiteCSharp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public ICMS ICMS { get; set; }
        public PIS PIS { get; set; }
        public COFINS COFINS { get; set; }
        public IPI IPI { get; set; }
        public ISSQN ISSQN { get; set; }
        public string CProd { get; set; }
        public string CEAN { get; set; }
        public string CEANTrib { get; set; }
        public string XProd { get; set; }
        public string CFOP { get; set; }
        public string NCM { get; set; }
        public string CEST { get; set; }
        public string VTotTrib { get; set; }
        public string IndRegra { get; set; }
        public string UCom { get; set; }
        public double VUnCom { get; set; }
        public int Quantity { get; set; }
    }
}
