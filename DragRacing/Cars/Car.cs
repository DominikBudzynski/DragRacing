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
        protected int enginePower;
        protected int grip;
        protected int gearBox;
        protected string model;
        protected int shopPrize;
        public int engineBonus, tireBonus;

        public Car()
        {
            EnginePower = 1;
            Grip = 1;
            GearBox = 1;
            model = string.Empty;
        }
        public Car(int enginePower, int grip, int gearBox, string model, int shopPrize)
        {
            this.enginePower = enginePower;
            this.grip = grip;
            this.gearBox = gearBox;
            this.model = model;
            this.shopPrize = shopPrize;
        }

        public int EnginePower
        {
            get { return (enginePower + engineBonus); }
            set
            {
                if (value > 0) engineBonus = value;
                else engineBonus = 0;
            }
        }

        public int Grip
        {
            get { return (grip + tireBonus); }
            set
            {
                if (value > 0) tireBonus = value;
                else tireBonus = 0;
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
