using Module9.Data;
using System;

namespace Module9
{
    static class Program
    {
        static void Main(string[] args)
        {
            IPrinter samsungPrinter = new SamsungPrinter();
            samsungPrinter.Print();
            samsungPrinter.Scan();
            Console.WriteLine(samsungPrinter);
            IPrinter hpPrinter = new HpPrinter();
            hpPrinter.Print();
            hpPrinter.Scan();
            Console.WriteLine(hpPrinter);
        }
    }
}
