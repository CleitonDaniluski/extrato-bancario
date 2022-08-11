using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Cleiton.ConsoleApplication
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value) 
        {
            var field = value.GetType().GetField(value.ToString());

            if (field == null) return null;

            var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute),false);

            if (attribute == null || attribute.Length < 1) return null;

            var description = (DescriptionAttribute)attribute[0]; 
               
            return description.Description;
        }
    }
}
