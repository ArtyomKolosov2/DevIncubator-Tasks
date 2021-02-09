using System;
using System.Collections.Generic;
using System.Text;

namespace Module6.Tasks
{
    public static class Task16
    {
        public static void ExecuteTask()
        {
            Console.WriteLine("Input array length, please: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var userArray = GetArrayFromUser(length);
                PrintEnumerable(userArray);
                ReplaceNullStringsInArray(userArray);
                PrintEnumerable(userArray);
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }

        public static void ReplaceNullStringsInArray(string [] array)
        {
            const string EMPTY_MESSAGE = "String is empty";
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = array[i] ?? EMPTY_MESSAGE;
            }
        }
        public static string[] GetArrayFromUser(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Amount of element can't be less than zero!");
            }

            var inputIndex = 0;
            var resultArray = new string[count];
            Console.WriteLine($"Input array with {count} elements, please");
            while (inputIndex < count)
            {
                var userInput = Console.ReadLine();
                if (userInput == string.Empty)
                {
                    userInput = null;
                }
                resultArray[inputIndex++] = userInput;
            }
            return resultArray;
        }

        public static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
            {
                Console.WriteLine($"{element} ");
            }
            Console.Write("\n");
        }
    }
}
