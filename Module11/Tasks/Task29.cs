using System;
using System.Collections.Generic;
using System.Text;

namespace Module11.Tasks
{
    public static class Task29
    {
        static LinkedList<int> CreateCircle(int amount)
        {
            LinkedList<int> resultCircle = new LinkedList<int>();
            for (var i = 1; i <= amount; i++)
            {
                resultCircle.AddLast(i);
            }

            return resultCircle;
        }

       
        public static void ExecuteTask()
        {
            Console.WriteLine("Input list length, please: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var circle = CreateCircle(length);
                var isElementEven = false;
                LinkedListNode<int> currentElement = circle.First;
                while (circle.Count != 1)
                {
                    var nextElement = currentElement.Next ?? circle.First;

                    if (isElementEven)
                    {
                        circle.Remove(currentElement);
                    }

                    isElementEven = !isElementEven;
                    currentElement = nextElement;
                }
                Console.WriteLine(circle.First.Value);
            }
            

            
        }
    }
}
