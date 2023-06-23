using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class RaceCar : Car
    {        
        private double turbo;
        private double aerodynamics;
        Random rnd = new Random();

        public RaceCar() : base()
        {
            turbo = 1;
            aerodynamics = 1;
        }

        public RaceCar(double enginePower, double grip, int gearBox, double turbo, double aerodynamics, string model) : 
                  base(enginePower, grip, gearBox, model)
        {
            Turbo = turbo;
            Aerodynamics = aerodynamics;
        }

        public double Turbo {
            get { return turbo; }
            set
            {
                if (value > 0)
                {
                    turbo = value;
                }
            }
        }

        public double Aerodynamics
        {
            get { return aerodynamics; }
            set
            {
                if (value > 0) aerodynamics = value;
            }
        }

        public override double Accelerate(double distance)
        {            
            double time = (0.6 * EnginePower + 0.2 * Grip + 0.4 * Turbo + 0.1 * Aerodynamics);
            double random = ((double)rnd.Next(90, 110) / 100.0);
            double result = (distance / ((0.5) * time * random));
            
            /*
            Console.WriteLine("Time = " + time);
            Console.WriteLine("Random = " + random);
            Console.WriteLine("Distance = " + distance);
            Console.WriteLine("Result = " + result);
            Console.WriteLine();
            Console.WriteLine("Time * Random = " + (time * random));
            Console.WriteLine("1/2 * Time * Random = " + ((0.5) * time * random));
            Console.WriteLine("Distance/result = " + (distance/ ((0.5)* time * random)));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            */
            return result;
        }       

    }
}
