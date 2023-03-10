using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}
