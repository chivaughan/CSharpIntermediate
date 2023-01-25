
using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new NetflixWebService());
            workflow.Add(new FileCompresser());
            workflow.Add(new VideoRenderer3D());
            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }
    }
}
