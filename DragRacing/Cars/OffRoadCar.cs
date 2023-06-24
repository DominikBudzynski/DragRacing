using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Cars
{
    internal class OffRoadCar : Car
    {
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        private double height;
        private double suspension;

        public OffRoadCar() : base()
        {
            height = 0;
            suspension = 0;
        }

        public OffRoadCar(double enginePower, double grip, double height, double suspension, string model) :
                     base(enginePower, grip, model)
        {
            Height = height;
            Suspension = suspension;
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
            }
        }

        public double Suspension
        {
            get { return suspension; }
            set
            {
                if (value > 0) suspension = value;
            }
        }

        public override double Accelerate(double distance)
        {
            return 0;
        }
    }
}
