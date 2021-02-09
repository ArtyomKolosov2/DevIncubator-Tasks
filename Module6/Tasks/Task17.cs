using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module6.Tasks
{
    public static class Task17
    {
        public static void ExecuteTask()
        {
            Console.WriteLine("Input list length, please: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var userList = GetListFromUser(length);
                PrintEnumerable(userList);
                Console.WriteLine(Math.Round(userList.Average().Value, 2));
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
            
        }
        public static List<int?> GetListFromUser(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Amount of element can't be less than zero!");
            }

            var currentAmount = 0;
            var resultList = new List<int?>(count);
            Console.WriteLine($"Input list with {count} elements, please");
            while (currentAmount < count)
            {
                var userInput = Console.ReadLine();
                if (userInput == string.Empty)
                {
                    resultList.Add(null);
                    currentAmount++;

                }
                else if (int.TryParse(userInput, out int parsedNum))
                {
                    resultList.Add(parsedNum);
                    currentAmount++;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
            return resultList;
        }

        public static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.WriteLine($"{element} ");
            }
            Console.Write("\n");
        }
    }
}
