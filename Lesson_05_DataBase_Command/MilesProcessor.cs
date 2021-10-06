using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Interface_Example
{
    class MilesProcessor
    {
        private readonly IMilesPerGallonCalc _milesCalc;

        public MilesProcessor (IMilesPerGallonCalc milesCalc)
        {
            _milesCalc = milesCalc;
        }

        public void Process(Trip trip)
        {
            //trip.SetMPG(_milesCalc.CalculateMPG(trip));
            trip._mpg = new Mpg
            {
                mpg = _milesCalc.CalculateMPG(trip)
            };                    
        }
    }
}
