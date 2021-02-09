using Module7.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module7.Tasks
{
    public static class Task20
    {

        public static void ExecuteTask()
        {
            Console.WriteLine("Input list length, please: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var userList = GetStudentListFromUser(length);
                Console.WriteLine($"Average - {Math.Round(userList.Average(student => student.averageGrade), 2)}");
                Console.WriteLine($"Max - {userList.Max(student => student.averageGrade)}");
                Console.WriteLine($"Min - {userList.Min(student => student.averageGrade)}");
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }

        public static List<Student> GetStudentListFromUser(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Amount of element can't be less than zero!");
            }

            var currentAmount = 0;
            var resultList = new List<Student>(count);
            Console.WriteLine($"Input list with {count} elements, please");
            while (currentAmount < count)
            {
                Console.WriteLine("Input name, please:");
                var name = Console.ReadLine();
                Console.WriteLine("Input lastname, please:");
                var lastName = Console.ReadLine();
                Console.WriteLine("Input averageMark, please:");
                if (double.TryParse(Console.ReadLine(), out double parsedMark))
                {
                    resultList.Add(new Student(lastName, name, parsedMark));
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
