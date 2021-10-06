using System;

namespace Lesson_08_WorkFlow_Engine
{
    public interface ITask
    {
        void Run();
    }

    class ProcessVideo : ITask
    {
        public void Run()
        {
            Console.WriteLine("Processing video...");
            // more code
        }
    }
    class EmailNotify : ITask
    {
        public void Run()
        {
            Console.WriteLine("Emailing notification...");
            // implementation
        }
    }
    class EncodeVideo : ITask
    {
        public void Run()
        {
            Console.WriteLine("Encoding video...");
            // more code
        }
    }
    class UploadVideo : ITask
    {
        public void Run()
        {
            Console.WriteLine("Uploading video...");
            // more code
        }
    }
}
