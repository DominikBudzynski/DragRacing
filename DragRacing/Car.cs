using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    abstract class Car : IRaceable
    {
        //USTAWIC ODPOWIEDNIE WARTOSCI W SETACH ITD
        private double enginePower;
        private double grip;
        private int gearBox;
        private string model;

        public Car()
        {
            EnginePower = 1;
            Grip = 1;
            GearBox = 1;
            model = string.Empty;
        }
        public Car(double enginePower, double grip, int gearBox, string model)
        {
            EnginePower = enginePower;
            Grip = grip;
            GearBox = gearBox;
            this.model = model;
        }

        public double EnginePower
        {
            get { return enginePower; }
            set
            {
                if (value > 0) enginePower = value;
                else enginePower = 1;
            }
        }

        public double Grip
        {
            get { return grip; }
            set
            {
                if (value > 0) grip = value;
                else grip = 1;
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
        public abstract double Accelerate(double distance);

        public override string ToString()
        {
            return model;
        }

    }
}
