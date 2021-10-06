using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Another_Interface_Example
{
    class Dog : IDog, IAnimal
    {
        public string Name { set; get; }

        public void Move()
        {
            Console.WriteLine($"The dog named {Name} is running");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is also barking");
        }
    }
}
