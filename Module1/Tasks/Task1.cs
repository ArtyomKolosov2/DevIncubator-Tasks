using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Tasks
{
    public static class Task1
    {
        public static void ExecuteTask()
        {
            // Task 1-a-1
            Console.WriteLine("Hello World!");
            // Task 1-a-2
            Console.WriteLine("Input your name, please: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input your age, please: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"My name is {name}. My age is {age}");

            // Task 1-b
            Console.WriteLine("Input double var, please: ");
            double doubleVar = double.Parse(Console.ReadLine());
            Console.WriteLine("Input byte var, please: ");
            byte byteVar = byte.Parse(Console.ReadLine());
            Console.WriteLine("Input char var, please: ");
            char charVar = char.Parse(Console.ReadLine());
            Console.WriteLine($"{doubleVar} {byteVar} {charVar}");

            // Task 1-c
            byte x = 255;
            sbyte y = 127;
            int z1 = int.MaxValue;
            int z2 = int.MinValue;
            float f1 = float.MaxValue;
            float f2 = float.MinValue;
            // There is a compilation error
            // z1 = int.MaxValue + 1
            // z2 = int.MaxValue - 1
            // x = 1000;
            // x = 256;
            // y = 128
            // f1 = float.MaxValue + 1.0f
            // f2 = float.MinValue - 1.0f

            // Task 1-d
            string hashStr = "Hello!";
            decimal hashDecimal = 1.0m;
            char hashChar = '#';
            Console.WriteLine($"" +
                $"string - {hashStr.GetHashCode()}\n " +
                $"decimal - {hashDecimal.GetHashCode()}\n " +
                $"char - {hashChar.GetHashCode()}");
            Console.WriteLine(
                $"{nameof(hashStr)} = {hashStr}\n" +
                $"{nameof(hashDecimal)} = {hashDecimal}\n" +
                $"{nameof(hashChar)} = {hashChar}");

            // Task 1-e
            object o1 = 5;
            object o2 = 5;
            object o3 = o1;
            Console.WriteLine($"o1 is equal o2 = {o1.Equals(o2)}");
            Console.WriteLine($"o2 is equal o3 = {o2.Equals(o3)}");
            Console.WriteLine($"o2 is reference equal o3 = {ReferenceEquals(o2, o3)}");
            Console.WriteLine($"o1 is reference equal o3 = {ReferenceEquals(o1, o3)}");

            // Task 1-f
            Console.WriteLine("Input a, please: ");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Input b, please: ");
            byte b = byte.Parse(Console.ReadLine());
            // There is a compilation error, cause we don't have + for types (byte, byte)
            // byte c = a + b;
            byte c1 = (byte)(a + b);
            Console.WriteLine(c1);

            // Task 1-g
            // There will be an OverflowException, if a + b > 255,
            byte c2 = checked((byte)(a + b));
            Console.WriteLine(c2);

            // Task 1-h
            long longA = 5L;
            int intB = 10;
            intB = (int)longA;
        }
    }
}
