using System;
using System.Collections.Generic;
using System.Text;

namespace Module2.Tasks
{
    public static class Task5
    {
        // Simple swap alghortim with ref
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void ExecuteTask()
        {
            Console.WriteLine("Input n, please: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input m, please: ");
            var m = int.Parse(Console.ReadLine());

            // if n greater than m, then swapping variables
            if (n > m)
            {
                Swap(ref n, ref m);
            }

            // Calculating numbers
            for (var currentNumber = n; currentNumber < m+1; currentNumber++)
            {
                if (currentNumber % 2 != 0)
                {
                    continue;
                }
                Console.Write($"{currentNumber} ");
            }
            Console.Write('\n');
        }
    }
}
