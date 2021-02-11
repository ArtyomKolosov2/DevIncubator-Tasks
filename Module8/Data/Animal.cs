using System;
using System.Collections.Generic;
using System.Text;

namespace Module8.Data
{
    public class Animal
    {
        public string Name { get; set; }
        public int FootNumber { get; set; }
        public bool HasMustache { get; set; }
        public Animal()
        {

        }
        public Animal(string name, int footNumber, bool hasMustache)
        {
            Name = name;
            FootNumber = footNumber;
            HasMustache = hasMustache;
        }
        public virtual void Voice()
        {
            Console.WriteLine("Voice");
        }
        public virtual void Move()
        {
            Console.WriteLine("Movement");
        }
        public virtual void IsHungry()
        {
            Console.WriteLine("Isn't hungry");

        }
    }
}
