using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class VelocityVector
    {
        public VelocityVector(double value, double angle)
        {
            this.Value = value;
            this.Angle = angle;
        }

        public double Value;
        public double Angle { get; set; }

       
    }
}
