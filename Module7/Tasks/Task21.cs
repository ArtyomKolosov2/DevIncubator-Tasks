using Module7.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module7.Tasks
{
    public static class Task21
    {
        public static void ExecuteTask()
        {
            Console.WriteLine("Input list length, please: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var userList = GetBelaviaListFromUser(length);
                Console.WriteLine("Enter type: ");
                var userType = Console.ReadLine();
                PrintBelavia(userList.Where(avia => avia.type == userType));
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }
        public static void PrintBelavia(IEnumerable<Belavia> enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.WriteLine($"{element.flightDestination} {element.aircraftNumber}");
            }
            Console.Write("\n");
        }

        public static List<Belavia> GetBelaviaListFromUser(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Amount of element can't be less than zero!");
            }

            var currentAmount = 0;
            var resultList = new List<Belavia>(count);
            Console.WriteLine($"Input list with {count} elements, please");
            while (currentAmount < count)
            {
                Console.WriteLine("Input destination, please:");
                var destination = Console.ReadLine();
                    
                Console.WriteLine("Input type, please:");
                var type = Console.ReadLine();
                Console.WriteLine("Input air number, please:");
                if (int.TryParse(Console.ReadLine(), out int parsedNumber))
                {
                    resultList.Add(new Belavia(destination, parsedNumber, type));
                    currentAmount++;
                }
                else
                {
                    Console.WriteLine("Ivalid data! Try again.");
                }
            }
            return resultList;
        }
    }
}
