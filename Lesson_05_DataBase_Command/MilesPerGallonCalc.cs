using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Interface_Example

{
    public interface IMilesPerGallonCalc
    {
        float CalculateMPG(Trip trip);
    }

    public class MilesPerGallonCalc : IMilesPerGallonCalc       //ctrl + . to refactor and extract interface
    {
        public float CalculateMPG(Trip trip)
        {
            float mpg = trip.GetMilesTraveled() / trip.GetGallonsUse();
            return mpg;
        }

    }
}
