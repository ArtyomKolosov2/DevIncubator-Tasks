using System;
using System.Collections.Generic;
using System.Text;

namespace Module2.Tasks
{
    
    public static class Task4
    {
        public static void ExecuteTask()
        {
           
            while (true)
            {
                Console.WriteLine("Input number between 1 - 7: ");
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    break;
                }

                // It's better to use switch expressions 
                string resultDay;
                switch (userNumber)
                {
                    case 1:
                        resultDay = "Monday";
                        break;
                    case 2:
                        resultDay = "Tuesday";
                        break;
                    case 3:
                        resultDay = "Wednesday";
                        break;
                    case 4:
                        resultDay = "Thursday";
                        break;
                    case 5:
                        resultDay = "Friday";
                        break;
                    case 6:
                        resultDay = "Saturday";
                        break;
                    case 7:
                        resultDay = "Sunday";
                        break;
                    default:
                        return;
                        
                }
                Console.WriteLine(resultDay);

            }
        }
    }
}
