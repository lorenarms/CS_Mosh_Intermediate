using System;

namespace Lesson_01
{
   public class StopWatch
    {
        private DateTime _timeStart;
        private DateTime _timeStop;
        private bool _isRunning;

        public StopWatch()
        {
            _timeStart = DateTime.Now;
        }

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _timeStart = DateTime.Now;
            _isRunning = true;
            
        }
        
        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not currently running!");
            }

            _timeStop = DateTime.Now;
            _isRunning = false;
            
        }


        public TimeSpan GetInterval()
        {
            
            return _timeStop - _timeStart;
            
        }

        public void Reset()
        {
            _timeStart = DateTime.Now;
        }

    }

    public class Driver
    {
        public static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            Console.WriteLine("Press enter to start the stopwatch...");
            Console.ReadKey();
            stopWatch.Start();
            Console.ReadKey();
            stopWatch.Stop();
            Console.WriteLine("Interval: " + stopWatch.GetInterval());

            

        }
    }
}
