using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithForPrintAttributes toPrintObject = new ClassWithForPrintAttributes("someLogin","Pass4#");

            Printer printer = new Printer();
            printer.Print(toPrintObject);

            Console.ReadLine();
        }
    }
}
