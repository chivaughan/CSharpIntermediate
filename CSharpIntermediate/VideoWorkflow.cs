using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class VideoWorkflow : IWorkflow
    {
        private List<string> _activities = new List<string>
            {
                    "Creating video",
                    "Compressing video",
                    "Video uploaded successfully"
            };

        public List<string> Activities { get => _activities; set => Activities = this._activities; }

        
        public void Execute(string activity)
        {
            Console.WriteLine(activity);
        }
    }
}
