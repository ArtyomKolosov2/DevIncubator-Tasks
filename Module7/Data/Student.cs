using System;
using System.Collections.Generic;
using System.Text;

namespace Module7.Data
{
    public class Student
    {
        private static int _studentCount = 0;
        public readonly string lastName;
        public readonly string name;
        public double averageGrade;
        public const int SCHOOL_NUMBER = 531;

        public Student(string lastName, string firstName, double average)
        {
            _studentCount++;
            this.lastName = lastName;
            this.name = firstName;
            this.averageGrade = average;
            Console.WriteLine($"Default ctor execution - {_studentCount}");
        }
        static Student()
        {
            Console.WriteLine($"Static ctor execution - {_studentCount}");
        }
        public static void ShowStudentsAmount()
        {
            Console.WriteLine(_studentCount);
        }

        public override string ToString()
        {
            return $"Student: {name} {lastName}\n" +
                $"AverageGrade: {averageGrade}\n" +
                $"School Number: {SCHOOL_NUMBER}";
        }
    }
}
