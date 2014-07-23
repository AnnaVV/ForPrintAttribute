using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Printer_Attributes
{
    class Printer
    {
        public void Print(object obj)
        {
            Type inputObjectType = obj.GetType();
            PropertyInfo [] properties = inputObjectType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetCustomAttribute(typeof(ForPrintAttribute)) != null)
                {
                    Console.ForegroundColor = property.GetCustomAttribute<ForPrintAttribute>().Color;
                    Console.WriteLine(property.GetValue(obj));   
                }
                
            }
        }
    }
}
