using System;
using System.Collections.Generic;
using System.Text;

namespace Module8.Data
{
    public class Kangaroo : Animal
    {
        public Kangaroo(string name, int footNumber, bool hasMustache) : base(name, footNumber, hasMustache)
        {

        }
        public override void Voice()
        {
            Console.WriteLine("khe-khe");
        }
        public override void Move()
        {
            Console.WriteLine("jump-jump");
        }
        public new void IsHungry()
        {
            Console.WriteLine("I want berries");
        }
    }
}
