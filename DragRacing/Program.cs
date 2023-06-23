using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using DragRacing.Cars;

namespace DragRacing
{
    class Program
    {        
        public static void Main()
        { 
            Game game = new Game();
            
            Thread.Sleep(1000);                                 
        }
    }
}

/*

namespace DragRacing
{
    class Program
    {
        public static MyTimer t1 = new MyTimer();
        public static float frameCounter = 0;
        public static float frameTime = 0;

        public static void Main()
        {



            Cars.RaceCar car = new Cars.RaceCar(70, 10, 1, 30, 20, "Lanos");
            Cars.RaceCar enemy = new Cars.RaceCar(100, 15, 1, 35, 20, "Nexia");

            Stage stage1 = new Stage(); ;


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
        }
    }
}
*/