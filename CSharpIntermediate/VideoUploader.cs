using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video");
        }
    }
}
