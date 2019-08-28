using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class StopWatch
    {

        private TimeSpan _duration;
        private DateTime _lastStart;
        private DateTime _lastStop;
        private bool _isStartedAlready;

        public StopWatch()
        {
            _lastStart = DateTime.Now;
            _lastStop = DateTime.Now;
            _isStartedAlready = false;
        }


        public void Start()
        {
            if (!_isStartedAlready)
            {
                _lastStart = DateTime.Now;
                _isStartedAlready = true;
            }
            else
            {
                throw new InvalidOperationException("Stop watch cannot be started multiple times without being stopped");
            }
            
        }

        public void Stop ()
        {
            _isStartedAlready = false;
            _lastStop = DateTime.Now;

            _duration = _lastStop.Subtract(_lastStart);
        }

        public void ShowTheDuration()
        {
            Console.WriteLine("Stop watch shows {0}", _duration);
        }
    }
}
