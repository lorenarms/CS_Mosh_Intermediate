using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Another_Interface_Example
{
    class Bird : IBird, IAnimal
    {
        public string Name { set; get; }

        public void Move()
        {
            Console.WriteLine($"The bird named {Name} is flying");
        }

        public void Squawk()
        {
            Console.WriteLine($"{Name} is also squawking");
        }
    }
}
