using Module10.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Tasks
{
    public static class Task25
    {
        public static IEnumerable<T> GetProducts<T>(int count, Func<T> constructor) where T : Product
        {
            if (count < 0)
            {
                throw new ArgumentException("Count can't be less than zero!");
            }
            if (constructor is null)
            {
                throw new ArgumentNullException(nameof(constructor), "Constructor can't be null!");
            }

            var resultList = new List<T>(count);
            for (var i = 0; i < count; i++)
            {
                resultList.Add(constructor.Invoke());
            }

            return resultList;
        }
        public static void ExecuteTask()
        {
            var breadRack1 = new Rack<Bread>();
            var breadRack2 = new Rack<Bread>();
            var breadRack3 = new Rack<Bread>();

            var milkRack1 = new Rack<Milk>();
            var milkRack2 = new Rack<Milk>();

            var pastaRack = new Rack<Pasta>();

            var porridgeRack = new Rack<Porridge>();

            breadRack1.AddProducts(GetProducts(30, () => new Bread("bread")));
            breadRack2.AddProducts(GetProducts(40, () => new Bread("bread")));
            breadRack3.AddProducts(GetProducts(40, () => new Bread("bread")));

            milkRack1.AddProducts(GetProducts(40, () => new Milk("milk")));
            milkRack2.AddProducts(GetProducts(45, () => new Milk("milk")));

            pastaRack.AddProducts(GetProducts(70, () => new Pasta("pasta")));

            porridgeRack.AddProducts(GetProducts(60, () => new Porridge("porridge")));

            Console.WriteLine($"Bread: {Rack<Bread>.Count}");
            Console.WriteLine($"Milk: {Rack<Milk>.Count}");
            Console.WriteLine($"Pasta: {Rack<Pasta>.Count}");
            Console.WriteLine($"Porridge: {Rack<Porridge>.Count}");


        }
    }
}
