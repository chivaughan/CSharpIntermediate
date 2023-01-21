
using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration);            
        }
    }
}
