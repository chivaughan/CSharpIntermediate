using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class StopWatch
    {
        public TimeSpan Duration 
        { 
            get
            {
                return EndTime - StartTime;
            }
            set { }
        }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        int ActiveInstances { get; set; }
        public StopWatch()
        {
            ActiveInstances = 0;
        }

        public void Start()
        {
            if (ActiveInstances >= 1)
                throw new InvalidOperationException("You have already started the stop watch");
            StartTime = DateTime.Now.TimeOfDay;
            Console.WriteLine(StartTime);
            Console.WriteLine("StopWatch has Started");
            ActiveInstances += 1;
        }

        public void Stop()
        {
            ActiveInstances -= 1;
            EndTime = DateTime.Now.TimeOfDay;
            Console.WriteLine(EndTime);
            Console.WriteLine("StopWatch has Stopped");
        }
    }
}
