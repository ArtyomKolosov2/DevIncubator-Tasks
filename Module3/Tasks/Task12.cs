using System;
using System.Collections.Generic;
using System.Text;

namespace Module3.Tasks
{
    public static class Task12
    {
        public static void ShowObjectTypes(params object [] objects)
        {
            foreach (var showObject in objects)
            {
                Console.Write($"{showObject.GetType()} ");
            }
            Console.Write('\n');
        }
        public static void ExecuteTask()
        {
            ShowObjectTypes(0, 0.0, false, 1m, 2UL, 3L);
            ShowObjectTypes();
            ShowObjectTypes("str", '1', -1);
        }
    }
}
