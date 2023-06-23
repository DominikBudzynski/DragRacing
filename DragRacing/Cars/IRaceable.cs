using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Cars
{
    interface IRaceable
    {
        double Accelerate(double distance);
        string ToString();
    }
}
