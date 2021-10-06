using System.Collections.Generic;

namespace Lesson_08_WorkFlow_Engine
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();


    }


    class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _tasks;    //declare the list of tasks

        public WorkFlow()
        {
            _tasks = new List<ITask>();     //create an empty list upon creation of object

        }
        public void Add(ITask task)         //add tasks to list
        {
            _tasks.Add(task);
        }
        public void Remove(ITask task)      //remove tasks from list
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()    //this keeps the list private and still returns the list items
        {
            IEnumerable<ITask> a;       //does not have list methods, cannot be changed
            

            return _tasks;      //returns a readonly version of the list
        }
    }
}
