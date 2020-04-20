using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Controllers.Extensions
{
    public static class EnumsExtensions
    {
        public static string GetDescription(this Enum item)
        {
            Type tipo = item.GetType();
            FieldInfo fi = tipo.GetField(item.ToString());
            DescriptionAttribute[] atributos =
            fi.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    as DescriptionAttribute[];
            if (atributos.Length > 0)
                return atributos[0].Description;
            else
                return string.Empty;
        }
    }
}
