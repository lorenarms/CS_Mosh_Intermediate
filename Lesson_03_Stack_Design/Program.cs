using System;

namespace Lesson_03_Stack_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(null);
            stack.Push(2);
            stack.Push(3);
            stack.Push("Name");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
