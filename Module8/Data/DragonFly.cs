using System;
using System.Collections.Generic;
using System.Text;

namespace Module8.Data
{
    public class DragonFly : Animal
    {
        public DragonFly(string name, int footNumber, bool hasMustache) : base(name, footNumber, hasMustache)
        {

        }
        public override void Voice()
        {
            Console.WriteLine("bj-w-w");
        }
        public override void Move()
        {
            Console.WriteLine("flight");
        }
        public new void IsHungry()
        {
            Console.WriteLine("I want insects");
        }
    }
}
