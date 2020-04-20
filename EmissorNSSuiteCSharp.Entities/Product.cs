
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
        public string ProductCode { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public string CFOP { get; set; }
        public string NCM { get; set; }
        public string CEST { get; set; }
        public string ApproximateAmountTaxas { get; set; }
        public string CalculationRule { get; set; } //SAT
        public string BusinessUnit { get; set; }
        public double UnitaryValue { get; set; }
        public int Quantity { get; set; }
        public int Origination { get; set; }
    }
}
