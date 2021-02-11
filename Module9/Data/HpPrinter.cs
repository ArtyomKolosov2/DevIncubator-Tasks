using System;
using System.Collections.Generic;
using System.Text;

namespace Module9.Data
{
    public class HpPrinter : Printer
    {
        public HpPrinter()
            : base("Hp", PrinterType.Ink, true)
        {

        }
        public override void Print()
        {
            Console.WriteLine("Let's print something with color inks!");
        }

        public override void Scan()
        {
            Console.WriteLine("Scan is available!");
        }
    }
}
