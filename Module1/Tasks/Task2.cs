using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Tasks
{
    public static class Task2
    {
        public static void ExecuteTask()
        {
            var decisionCounter = 0;
            var positiveAnswer = "yes";
            var negativeAnswer = "no";
            Console.WriteLine("Have you done all your homework?");
            string answer = Console.ReadLine().ToLower();
            if (answer == positiveAnswer)
            {
                decisionCounter++;
            }
            Console.WriteLine("Did you make a team project?");
            answer = Console.ReadLine().ToLower();
            if (answer == positiveAnswer)
            {
                decisionCounter++;
            }
            Console.WriteLine("If you have debt at university?");
            answer = Console.ReadLine().ToLower();
            if (answer == negativeAnswer)
            {
                decisionCounter++;
            }
            Console.WriteLine(decisionCounter == 3 ?
                "Today you can go for a walk with friends.":
                "You still have things to do, you can't go out with your friend today.");

        }
    }
}
