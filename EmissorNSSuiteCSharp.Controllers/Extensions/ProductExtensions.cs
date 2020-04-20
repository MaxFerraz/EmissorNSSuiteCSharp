using EmissorNSSuiteCSharp.DAO;
using EmissorNSSuiteCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Controllers.Extensions
{
    public static class ProductExtensions
    {
        public static List<Product> Register(this Product p)
        {           
            using (var contextProd = new ProductsDAO())
            {
                contextProd.Add(p);
                return contextProd.Products();
            }
        }
    }
}
