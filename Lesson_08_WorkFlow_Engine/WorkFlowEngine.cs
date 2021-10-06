using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_WorkFlow_Engine
{
    public class WorkFlowEngine
    {
        
        public void Execute(IWorkFlow workFlow)
        {
            foreach (ITask task in workFlow.GetTasks())
            {
                task.Run();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();      //make a new workflow object to store various tasks
            workFlow.Add(new UploadVideo());    //add tasks to workflow
            workFlow.Add(new EncodeVideo());
            workFlow.Add(new EmailNotify());
            workFlow.Add(new ProcessVideo());

            var engine = new WorkFlowEngine();  //make a new workflowengine object to execute the workflow
            engine.Execute(workFlow);           //execute the workflow by passing it to the engine


            Console.ReadKey();
        }
    }
}
