using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Another_Interface_Example
{
    public interface IAnimal
    {
        string Name { get; set; }

        void Move();
    }
}
