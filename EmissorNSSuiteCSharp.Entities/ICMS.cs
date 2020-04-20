using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Entities
{
    public class ICMS
    {
        public Product Product { get; set; }
        public string CST { get; set; }
        public string CSOSN { get; set; }
        public double AliqICMS { get; set; }
        public double AliqICMSCred { get; set; }
        public double ValueICMSCred { get; set; }

    }
}
