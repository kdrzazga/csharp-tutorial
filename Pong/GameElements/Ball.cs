using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        public Ball(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.V = new VelocityVector(3, Math.PI / 4);
        }

        internal void Move()
        {
            this.X += (int)(this.V.Value * Math.Sin(this.V.Angle));
            this.Y += (int)(this.V.Value * Math.Cos(this.V.Angle));
        }

        private int X;
        private int Y;
        private VelocityVector V;
    }
}
