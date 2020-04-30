using EmissorNSSuiteCSharp.Entities;
using EmissorNSSuiteCSharp.Models.TamplatesSefaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Controllers
{
    public class TNFeController : IProductController
    {
        public void ToJSON(Issuer issuer, Recipient recipient, List<Product> products)
        {
            var NFe = new TNFe()
            {

            };
        }
    }
}
