using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow)
        {
            _workflow = workflow;
        }

        public void Run()
        {
            foreach (string activity in _workflow.Activities)
                _workflow.Execute(activity);
        }
    }
}
