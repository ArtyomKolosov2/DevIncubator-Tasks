using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module3.Tasks
{
    public static class Task7
    {
        public static IEnumerable<int> ParseString(string source)
        {
            return source.Split().Select(int.Parse);
        }
        public static void ExecuteTask()
        {
            Console.WriteLine("Input results, please: ");
            var results = ParseString(Console.ReadLine()).ToList();
            results.Remove(results.Max());
            results.Remove(results.Min());
            Console.WriteLine(Math.Round(results.Average(), 2));
        }
    }
}
