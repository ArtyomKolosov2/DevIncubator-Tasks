using System;
using System.Collections.Generic;
using System.Text;

namespace Module6.Tasks
{
    // Using my own implementation instead System.DateTime.DayOfWeek
    public enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public static class Task18
    {
        public static void ExecuteTask()
        {
            Console.WriteLine("Input number [1 - 7], please");
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedNum))
            {
                if (parsedNum > 0 && parsedNum < 8)
                {
                    Console.WriteLine(((DaysOfWeek)parsedNum).ToString());
                }
                else
                {
                    Console.WriteLine(parsedNum);
                }
            }
        }
    }
}
