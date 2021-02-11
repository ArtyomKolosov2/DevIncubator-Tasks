using System;
using System.Collections.Generic;
using System.Text;

namespace Module9.Data
{
    public class SamsungPrinter : Printer
    {
        public SamsungPrinter() 
            : base("Samsung", PrinterType.Laser, false)
        {

        }
        public override void Print()
        {
            Console.WriteLine("Let's print something with laser!");
        }

        public override void Scan()
        {
            Console.WriteLine("Scan isn't available!");
        }
    }
}
