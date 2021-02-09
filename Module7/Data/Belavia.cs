using System;
using System.Collections.Generic;
using System.Text;

namespace Module7.Data
{
    public struct Belavia
    {
        public string flightDestination;
        public string type;
        public int aircraftNumber;
        public Belavia(string destination, int number, string type)
        {
            flightDestination = destination;
            aircraftNumber = number;
            this.type = type;
        }
    }
}
