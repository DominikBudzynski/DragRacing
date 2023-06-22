using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace DragRacing
{
    class Program
    {
        public static MyTimer t1 = new MyTimer();
        
        public static void Main()
        {
            t1.startTimer();

            while (true)
            {               
                t1.RecordTime();
                t1.SleepFrame();                
            }
        }

    }
}

