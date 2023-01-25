
using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new VideoWorkflow();
            workflow.Activities.Add("I added a new workflow");
            workflow.Activities.Add("I added another new workflow");
            var engine = new WorkflowEngine(workflow);
            engine.Run();
        }
    }
}
