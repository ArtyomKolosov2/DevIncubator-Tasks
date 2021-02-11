using System;
using System.Collections.Generic;
using System.Text;

namespace Module9.Data
{
    public abstract class Printer : IPrinter
    {
        protected bool isScanPossible;
        private protected PrinterType PrinterType { get; set; }
        public string PrinterName { get; set; }
        protected Printer(string name, PrinterType printerType, bool isScanPossible)
        {
            PrinterName = name;
            PrinterType = printerType;
            this.isScanPossible = isScanPossible;
        }
        public override string ToString()
        {
            return $"Name: {PrinterName}, Scan: {isScanPossible}, PrinterType: {PrinterType}";
        }
        public abstract void Print();
        public abstract void Scan();
    }
}
