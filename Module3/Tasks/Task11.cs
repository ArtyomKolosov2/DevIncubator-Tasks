using System;
using System.Collections.Generic;
using System.Text;

namespace Module3.Tasks
{
    public static class Task11
    {
        public static string GetFullName(
            string name = "", 
            string middleName = "", 
            string lastName = "")
        {
            return $"{name} {middleName} {lastName}";
        }
        public static void ExecuteTask()
        {
            Console.WriteLine(GetFullName("Alex"));
            Console.WriteLine(GetFullName("Fred", "McGreggor"));
            Console.WriteLine(GetFullName("Vasilit", "McGreggor", "Petrovich"));
        }
    }
}
