using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Controllers.Exceptions
{
    public class RequiredFieldException :Exception
    {
        private string msg;

        public RequiredFieldException(string field)
        {
            msg = $"O campo '{field}' é obrigatorio para o cadastro do produto!";
        }
        public override string Message => msg;
    }
}
