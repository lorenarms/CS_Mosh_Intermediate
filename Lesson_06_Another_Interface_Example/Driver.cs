using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Another_Interface_Example
{
    class Driver
    {
        public static void Main(string[] args)
        {
            List<IAnimal> animalList = new List<IAnimal>();

            animalList.Add(new Dog { Name = "Sparky" });
            animalList.Add(new Dog { Name = "Ranger" });
            animalList.Add(new Bird { Name = "Flappy" });
            animalList.Add(new Bird { Name = "Windy" });
            animalList.Add(new Dog { Name = "Fido" });

            foreach(IAnimal animal in animalList)
            {
                animal.Move();

                if (animal is IDog dog)
                {
                    dog.Bark();
                }
                if (animal is IBird bird)
                {
                    bird.Squawk();
                }

                
            }

            Console.ReadKey();
        }
       

        

    }
}