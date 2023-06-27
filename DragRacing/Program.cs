using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using DragRacing.Cars;
using DragRacing.Game;

namespace DragRacing
{
    class Program
    {
        public Player player = new Player();

        public static void Main()
        { 
            Game.Game game = new Game.Game();
            StageInitializer stageInit = new StageInitializer();

            List <Stage> stages = new List <Stage>();
            stages.Add(stageInit.InitStage(1));
            stages.Add(stageInit.InitStage(2));
            stages.Add(stageInit.InitStage(3));
            stages.Add(stageInit.InitStage(4));

            StageHandler hStage = new StageHandler(stages);
            game.HStage = hStage;

            while (true)
            {
                Console.Clear();
                //get user nickname
                game.UpdateGame();
                //Thread.Sleep(1000);
            }
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