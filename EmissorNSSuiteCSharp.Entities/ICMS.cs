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
        public int Origination { get; set; }
        public string CST { get; set; }
        public string CSOSN { get; set; }
        public string pICMS { get; set; }
        public string pCredSN { get; set; }
        public string pICMSST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string pFCPST { get; set; }
        public string pFCP { get; set; }
        public string pST { get; set; }
        public string vCredICMSSN { get; set; }
        public int modBCST { get; set; }
        public int modBC { get; set; }
        public int vBCSTRet { get; set; }
        public string vICMSSubstituto { get; set; }
        public string vICMSSTRet { get; set; }
        public string pFCPSTRet { get; set; }
        public string pRedBCEfet { get; set; }
        public string pICMSEfet { get; set; }
        public string pRedBC { get; set; }
        public string motDesICMS { get; set; }

    }
}
