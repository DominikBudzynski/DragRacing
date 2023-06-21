using System;

namespace DragRacing
{
    class Program
    {
        static void Main()
        {
            RaceCar car1 = new RaceCar(150, 2, 5, 10, 300, "Lanos Turbo");

            OffRoadCar car2 = new OffRoadCar();

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
        }
    }
}
