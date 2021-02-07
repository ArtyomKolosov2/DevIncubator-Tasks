using System;
using System.Collections.Generic;
using System.Text;

namespace Module3.Tasks
{
    
    public static class Task8
    {
        public static (int, int, int, int, int) CalculateExpression(int a, int b)
        {
            (var sum, var substruction, var multiply, var division) = (a + b, a - b, a * b, a / b);
            return (sum, substruction, multiply, division,
                sum +
                substruction +
                multiply +
                division);
        }

        public static (double, double, double, double, double) CalculateExpression(double a, double b)
        {
            (var sum, var substruction, var multiply, var division) = (a + b, a - b, a * b, a / b);
            return (sum, substruction, multiply, division,
                sum +
                substruction +
                multiply +
                division);
        }

        public static void ExecuteTask()
        {
            Console.WriteLine(CalculateExpression(2, 4));
            Console.WriteLine(CalculateExpression(10, 5));
            Console.WriteLine(CalculateExpression(10.0, 4.0));
        }
    }
}
