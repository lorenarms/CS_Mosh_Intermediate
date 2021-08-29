using System;

namespace Lesson_01
{
   public class StopWatch
    {
        private DateTime _timeStart;

        public StopWatch()
        {
            _timeStart = DateTime.Now;
        }

        public void Start()
        {
            if(_timeStart == null)
                _timeStart = DateTime.Now;
            Console.WriteLine(_timeStart.Second);
        }
        
        public void Stop()
        {
            var timeSpan = DateTime.Now - _timeStart;
            Console.WriteLine(timeSpan);
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
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Reset();
            stopWatch.Start();
            stopWatch.Stop();

        }
    }
}
