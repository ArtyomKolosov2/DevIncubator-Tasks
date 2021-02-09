using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Module6.Tasks
{
    public static class Task19
    {
        public static void ExecuteTask()
        {
            var iterationCount = 100000000;
            var stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            for (var i = 0; i < iterationCount; i++)
            {
                ;
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalSeconds);

            stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            for (var i = 0; i < iterationCount; i++)
            {
                object counter = i;
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalSeconds);
        }
    }
}
