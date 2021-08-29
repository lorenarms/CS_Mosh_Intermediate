using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_03_Stack_Design
{
    class Stack
    {
        //use a generic list of objects
        List<Object> newStack = new List<Object>();
        
        public void Push(Object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Nothing was passed, nothing was stored");
                return;
            }
            
            
            //items are sent as objects, stored at the beginning of the list
            newStack.Insert(0, obj);

        }

        public object Pop()
        {
            //get object at index [0], then remove it from the list
            object obj = null;
            obj = newStack[0];

            newStack.RemoveAt(0);

            //return that object for printing
            return obj;
        }

        public void Clear()
        {
            //clears the list
            newStack.Clear();

        }
    }
}
