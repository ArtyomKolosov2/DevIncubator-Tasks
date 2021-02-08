using System;
using System.Collections.Generic;
using System.Text;

namespace Module4.Tasks
{
    public static class Task13
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static int [] GetArrayFromUser(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Amount of element can't be less than zero!");
            }

            var inputIndex = 0;
            var resultArray = new int[count];
            Console.WriteLine($"Input array with {count} elements, please");
            while (inputIndex < count)
            {
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int parsedNum))
                {
                    resultArray[inputIndex] = parsedNum;
                    inputIndex++;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
            return resultArray;
        }

        public static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.Write($"{element} ");
            }
            Console.Write("\n");
        }

        public static void BubbleSort(int [] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "Source array can't be null");
            }

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }
        public static void ExecuteTask()
        {
            Console.WriteLine("Input array length, please: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var userArray = GetArrayFromUser(length);
                PrintEnumerable(userArray);
                BubbleSort(userArray);
                PrintEnumerable(userArray);
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }
    }
}
