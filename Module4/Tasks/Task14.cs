using System;
using System.Collections.Generic;
using System.Text;

namespace Module4.Tasks
{
    public static class Task14
    {
        public static int[,] GetTwoDimensionalArray(int n, int m)
        {
            if (n < 0)
            {
                throw new ArgumentException("N can't be less than zero!", nameof(n));
            }

            if (m < 0)
            {
                throw new ArgumentException("M can't be less than zero!", nameof(m));
            }

            var resultArray = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    resultArray[i, j] = i - j;
                }
            }
            return resultArray;
        }

        public static void PrintTwoDimensioalArray(int[,] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "Source array can't be null");
            }

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j], 3} ");
                }
                Console.Write('\n');
            }
        }


        public static void ExecuteTask()
        {
            Console.WriteLine("Input n, please: ");
            var nResult = int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("Input m, please: ");
            var mResult = int.TryParse(Console.ReadLine(), out int m);

            if (nResult && mResult)
            {
                var array = GetTwoDimensionalArray(n, m);
                PrintTwoDimensioalArray(array);
                var arraySum = 0;
                foreach (var element in array)
                {
                    arraySum += element;
                }
                Console.WriteLine(
                    $"Array length = {array.Length}\n" +
                    $"Array dimension = {array.Rank}\n" +
                    $"Sum of elements = {arraySum}");
            }
        }
    }
}
