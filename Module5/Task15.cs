using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Module5
{
    public static class Task15
    {
        public static void ExecuteTask()
        {
            var sourceString = Console.ReadLine();
            var wordsList = Regex.Split(sourceString, @"\W+");
            PrintEnumerable(wordsList);
            wordsList = wordsList.Distinct().ToArray();
            PrintEnumerable(wordsList);
            
        }
        public static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.Write($"{element} ");
            }
            Console.Write("\n");
        }
    }
}
