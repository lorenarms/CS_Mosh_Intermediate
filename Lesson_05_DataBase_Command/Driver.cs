using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Interface_Example
{
    class Driver
    {
        static void Main(string[] args)
        {
            var milesProcessor = new MilesProcessor(new MilesPerGallonCalc());
            var newTrip = new Trip(200, 15);
            milesProcessor.Process(newTrip);
            
            Console.WriteLine("Miles per gallon: " + newTrip.GetMPG());

            Console.ReadKey();
        }

    }
}
