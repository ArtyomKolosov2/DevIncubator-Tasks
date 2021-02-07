using System;
using System.Collections.Generic;
using System.Text;

namespace Module2.Tasks
{
    public static class Task3
    {
        public static void ExecuteTask()
        {
            for (var row = 1; row < 10; row++)
            {
                for (var column = 1; column < 10; column++)
                {
                    Console.Write($"{row * column, 3}");
                }
                Console.Write('\n');
            }
        }
    }
}
