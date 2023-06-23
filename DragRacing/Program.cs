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
        public static float frameCounter = 0;
        public static float frameTime = 0;
        
        public static void Main()
        {
            t1.startTimer();
            RaceCar car = new RaceCar(70, 10, 1, 30, 20, "Lanos");
            RaceCar enemy = new RaceCar(100, 15, 1, 35, 20, "Nexia");


            
            while (true)
            {
                frameTime = t1.RecordTime();

                //Console.WriteLine("Accelerate: " + car.Accelerate(500));

                double time1 = car.Accelerate(500);
                double time2 = enemy.Accelerate(500);
                
                if (time1 > time2)
                {
                    Console.WriteLine(enemy.ToString() + " wins.\n" + "Time: " + time2);
                }
                else
                {
                    Console.WriteLine(car.ToString() + " wins.\n" + "Time: " + time1);
                }
                
                Thread.Sleep(1000);
                //t1.SleepFrame();                                   
            }
        }

    }
}

