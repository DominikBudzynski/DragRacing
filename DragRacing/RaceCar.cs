using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class RaceCar : Car
    {
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        private double turbo;
        private double aerodynamics;
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
            return 0;
        }

    }
}
