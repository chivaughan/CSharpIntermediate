using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public interface IWorkflow
    {
        List<string> Activities { get; set; }
        void Execute(string activity);
    }
}
