using System;
using System.Collections.Generic;
using System.Text;

namespace Module3.Tasks
{
    public static class Task10
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static (int, int) Swap(int a, int b) => (b, a);
        public static void ExecuteTask()
        {
            int a = 5,
                b = 10;
            Console.WriteLine($"a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Swapped a and - a = { a}, b = { b}");
            Console.WriteLine($"a = {a}, b = {b}");
            (a, b) = Swap(a,b);
            Console.WriteLine($"Swapped a and - a = {a}, b = { b}");
        }
    }
}
