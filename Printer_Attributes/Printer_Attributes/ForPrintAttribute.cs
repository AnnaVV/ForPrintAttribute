using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ForPrintAttribute:Attribute
    {
        private ConsoleColor _color;

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public ForPrintAttribute()
        {
            Color = ConsoleColor.White;
        }
        public ForPrintAttribute(ConsoleColor color)
        {
            this._color = color;
        }
    }
}
