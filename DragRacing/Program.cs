using System;

namespace DragRacing
{
    class Program
    {
        static void Main()
        {
            RaceCar car1 = new RaceCar(150, 2, 5, 10, 300);

            Console.WriteLine(car1.EnginePower);
        }
    }
}
