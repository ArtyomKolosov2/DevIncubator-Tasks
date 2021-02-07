using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2.Tasks
{
    public static class Task6
    {
        public static void ExecuteTask()
        {
            Console.WriteLine("Input first number, please: ");
            var firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number, please: ");
            var secondNum = int.Parse(Console.ReadLine());
            foreach (var num in firstNum.FindSameNumbers(secondNum))
            {
                Console.Write($"{num} ");
            }
            Console.Write('\n');
            
        }
    }

    public static class IntExtension
    {
        public static IEnumerable<int> GetNumbers(this int num)
        {
            num = Math.Abs(num);
            var numbers = new List<int>();
            while (num > 0)
            {
                numbers.Add(num % 10);
                num /= 10;
            }
            return numbers;
        }
        public static IEnumerable<int> FindSameNumbers(this int num1, int num2)
        {
            
            var firstNums = num1.GetNumbers();
            var secondNums = num2.GetNumbers();
            var intersectList = firstNums.Intersect(secondNums);
            var resultList = new List<int>();
            foreach (var num in intersectList)
            {
                var firstCount = firstNums.Count(n => n == num);
                var secondCount = secondNums.Count(n => n == num); 
                var longestCount = firstCount > secondCount ? firstCount : secondCount;
                resultList.AddRange(Enumerable.Repeat(num, longestCount));
            }
            return resultList;

        }
    }
}
