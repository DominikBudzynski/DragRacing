using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class Car : IRaceable
    {
        private double enginePower;
        private double grip;
        private int gearBox;

        public double EnginePower
        {
            get { return enginePower; }
            set
            {
                if (value > 0) enginePower = value;
                else enginePower = 1;   //DO KOREKTY
            }
        }

        public double Grip
        {
            get { return grip; }
            set
            {
                if (value > 0) grip = value;
            }
        }

        public int GearBox
        {
            get { return gearBox; }
            set
            {
                if (value > 0 && value < 8) gearBox = value;
            }
        }
        public virtual double Accelerate(double distance)
        {
            return 0;
        }

        public override string ToString()
        {
            return "This is a car.";
        }

    }
}
