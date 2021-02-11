using System;
using System.Collections.Generic;
using System.Text;

namespace Module11.Tasks
{
    public static class Task28
    {
        public static IEnumerable<int> GetPrimeNumbers(int count)
        {
            var primeList = new List<int>(count);
            for (var i = 0; i <= count; i++)
            {
                var isPrime = true;
                for (var j = 2; j < i; j++) 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }

        public static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.Write($"{element} ");
            }
            Console.Write("\n");
        }
        public static void ExecuteTask()
        {
            PrintEnumerable(GetPrimeNumbers(50));
            PrintEnumerable(GetPrimeNumbers(500));
        }
    }
}
