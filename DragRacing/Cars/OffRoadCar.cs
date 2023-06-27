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
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        private double height;
        private int suspension;
        public int suspensionBonus;

        public OffRoadCar() : base()
        {
            height = 0;
            suspension = 0;
        }

        public OffRoadCar(double enginePower, double grip, int gearBox, double height, int suspension, string model, int shopPrize) :
                     base(enginePower, grip, gearBox, model, shopPrize)
        {
            this.height = height;
            this.suspension = suspension;
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
            }
        }

        public int Suspension
        {
            get { return (suspension + suspBonus); }
            set
            {
                if (value > 0) suspBonus = value;
            }
        }

        public override double Accelerate(double distance)
        {
            return 0;
        }

        public override string ToString()
        {
            return model +
                " Engine power: " + enginePower +
                " Grip: " + grip +
                " Suspension: " + suspension +
                " cos dodawtkowo: " + "\n";
        }
    }
}
