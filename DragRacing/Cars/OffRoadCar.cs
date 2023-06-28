using DragRacing.States.ShopStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Cars
{
    internal class OffRoadCar : Car
    {        
        Random rnd = new Random();
        private double airFilter;
        private double suspension;
        public double suspensionBonus, airFilterBonus;

        public OffRoadCar() : base()
        {
            airFilter = 0;
            suspension = 0;
        }

        public OffRoadCar(double enginePower, double grip, double height, double suspension, string model, int shopPrize) :
                     base(enginePower, grip, model, shopPrize)
        {
            this.airFilter = height;
            this.suspension = suspension;
        }

        public double AirFilter
        {
            get { return airFilter; }
            set
            {
                if (value > 0) airFilter = value;
            }
        }

        public double Suspension
        {
            get { return (suspension + suspensionBonus); }
            set
            {
                if (value > 0) suspensionBonus = value;
            }
        }

        public override double Accelerate(double distance, List<double> bonus)
        {
            double time = 0.6 * EnginePower + 0.2 * Grip + 0.4 * Suspension + 0.1 * AirFilter;
            double random = rnd.Next(90, 110) / 100.0;
            double result = bonus[1] * (distance / (0.5 * time * random));
            return result;
        }

        public override string ToString()
        {
            return model +
                " Engine power: " + EnginePower.ToString() +
                " Grip: " + Grip.ToString() +
                " Suspension: " + Suspension.ToString() +
                " cos dodawtkowo: " + "\n";
        }
    }
}
