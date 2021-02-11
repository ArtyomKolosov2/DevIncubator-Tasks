using Module8.Data;
using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            var herd = new Animal[7];
            herd[0] = new Horse("Horse", 4, false);
            herd[1] = new Kangaroo("Kangaroo", 2, false);
            herd[2] = new Kangaroo("Kangaroo", 2, true);
            herd[3] = new DragonFly("DragonFly", 10, true);
            herd[4] = new Horse("Horse", 4, false);
            herd[5] = new Horse("Horse", 4, false);
            herd[6] = new Animal("Unknown", 2, true);
            var horse = new Horse("Horse", 4, false);
            var kangoroo = new Kangaroo("Kangoroo 3", 4, true);
            var dragonFly = new DragonFly("dragon 3", 6, true);
            foreach (var animal in herd)
            {
                Console.Write($"{animal.Name} ");
                animal.Voice();
            }
            horse.Voice();
            kangoroo.Voice();
            dragonFly.Voice();
            // Move method is called
            foreach (var animal in herd)
            {
                Console.Write($"{animal.Name} ");
                animal.Move();
            }
            horse.Move();
            kangoroo.Move();
            dragonFly.Move();
            foreach (var animal in herd)
            {
                Console.Write($"{animal.Name} ");
                animal.IsHungry();
            }
            horse.IsHungry();
            kangoroo.IsHungry();
            dragonFly.IsHungry();
        }
    }
}
