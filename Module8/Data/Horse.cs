using System;
using System.Collections.Generic;
using System.Text;

namespace Module8.Data
{
    public class Horse : Animal
    {
        public Horse(string name, int footNumber, bool hasMustache) : base(name, footNumber, hasMustache)
        {

        }
        public override void Voice()
        {
            Console.WriteLine("I-go-go");
        }
        public override void Move()
        {
            Console.WriteLine("top-top");
        }
        public new void IsHungry()
        {
            Console.WriteLine("I want hay");
        }
    }
}
