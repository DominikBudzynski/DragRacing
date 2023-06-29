using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DragRacing.Cars
{
    class RaceCar : Car
    {
        private double turbo, aerodynamics;
        public double turboBonus, aeroBonus;        
        Random rnd = new Random();

        public RaceCar() : base()
        {
            turbo = 1;
            aerodynamics = 1;
        }

        public RaceCar(int enginePower, int grip, int turbo, int aerodynamics, string model, int shopPrize) :
                  base(enginePower, grip, model, shopPrize)
        {
            this.turbo = turbo;
            this.aerodynamics = aerodynamics;
        }

        public double Turbo
        {
            get { return (turbo + turboBonus); }
            set
            {
                if (value > 0)
                {
                    turboBonus = value;
                }
            }
        }

        public double Aerodynamics
        {
            get { return (aerodynamics + aeroBonus); }
            set
            {
                if (value > 0) aeroBonus = value;
            }
        }

        public override double Accelerate(double distance)
        {
            double time = 0.6 * EnginePower + 0.2 * Grip + 0.4 * Turbo + 0.1 * Aerodynamics;
            double random = rnd.Next(90, 110) / 100.0;
            double result = (distance / (0.5 * time * random));
            return result;
        }

        public override double Accelerate(double distance, List<double> bonus)
        {
            double time = 0.6 * EnginePower + 0.2 * Grip + 0.4 * Turbo + 0.1 * Aerodynamics;
            double random = rnd.Next(90, 110) / 100.0;
            double result = bonus[0] * (distance / (0.5 * time * random));
            return result;
        }

        public override string ToString()
        {
            return model +
                " Engine power: " + EnginePower.ToString() +
                " Grip: " + Grip.ToString() +
                " Turbocharge: " + Turbo.ToString() +
                " Aerodynamics: " + Aerodynamics.ToString() +
                " Prize: " + ShopPrize().ToString() + "\n";
        }

    }
}
