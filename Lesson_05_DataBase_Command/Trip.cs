using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Interface_Example
{
    public class Mpg
    {
        public double mpg;
    }
    public class Trip
    {
        private int _milesTraveled;
        private int _gallonsUsed;
        public Mpg _mpg;

        public Trip(int miles, int gal)
        {
            _milesTraveled = miles;
            _gallonsUsed = gal;
        }

        public int GetMilesTraveled()
        {
            return _milesTraveled;
        }
        public int GetGallonsUse()
        {
            return _gallonsUsed;
        }

        
        public double GetMPG()
        {
            return _mpg.mpg;
        }
    }
}
