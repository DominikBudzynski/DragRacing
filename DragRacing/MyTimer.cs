using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class MyTimer
    {
        private long freq = Stopwatch.Frequency;
        private long elapsedTime;
        private bool isStarted;
        private static Stopwatch sw;

        public MyTimer()
        {
            elapsedTime = 0;
            isStarted = false;
            sw = new Stopwatch();
        }

        public void startTimer()
        {
            sw.Start();
            isStarted = true;
        }

        /*
         * returns time in miliseconds
        */
        public float RecordTime()
        {
            if (isStarted)
            {
                sw.Stop();
                elapsedTime = sw.ElapsedTicks;
                return (elapsedTime); //f = 10E7Hz
                
            }
            return 0;
        }

        public void SleepFrame()
        {
            if (isStarted)
            {
                if (elapsedTime < 166000)
                {
                    Thread.Sleep(8 - (int)elapsedTime/1000);
                    //1ms - 1000
                    //f = 10E7
                    //60FPS - frame lasts 16.6 ms
                }
            }            
        }

    }
}
