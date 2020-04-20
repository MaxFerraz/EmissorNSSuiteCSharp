using EmissorNSSuiteCSharp.Controllers.Extensions;
using EmissorNSSuiteCSharp.Models;
using EmissorNSSuiteCSharp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissorNSSuiteCSharp.Controllers
{
    public class EnumsGenericController
    {
        public IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }
        public T GetEnumByDescription<T>(string description)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = EnumToList<T>();
            foreach (T item in list)
            {
                if (((Enum)Enum.Parse(typeof(T),
                       item.ToString())).GetDescription() == description)
                    return item;
            }

            throw new Exception("The description is invalid");
        }
    }
}
