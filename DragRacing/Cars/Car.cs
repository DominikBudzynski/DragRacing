using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Cars
{
    abstract class Car : IRaceable
    {
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        protected double enginePower, engineBonus;
        protected double grip, gripBonus;
        protected int gearBox;
        protected string model;
        protected int shopPrize;

        public Car()
        {
            EnginePower = 1;
            Grip = 1;
            GearBox = 1;
            model = string.Empty;
        }
        public Car(double enginePower, double grip, int gearBox, string model, int shopPrize)
        {
            this.enginePower = enginePower;
            this.grip = grip;
            this.gearBox = gearBox;
            this.model = model;
            this.shopPrize = shopPrize;
        }

        public double EnginePower
        {
            get { return (enginePower + engineBonus); }
            set
            {
                if (value > 0) engineBonus = value;
                else engineBonus = 0;
            }
        }

        public double Grip
        {
            get { return (grip + gripBonus); }
            set
            {
                if (value > 0) gripBonus = value;
                else gripBonus = 0;
            }
        }

        public int GearBox
        {
            get { return gearBox; }
            set
            {
                if (value > 0 && value < 8) gearBox = value;
                else gearBox = 1;
            }
        }

        public int ShopPrize() => shopPrize;
        public abstract double Accelerate(double distance);

        public override string ToString()
        {
            return model;
        }

    }
}
