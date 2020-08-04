using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.GameElements
{
    class Board
    {
        private Ball Ball;
        private Bat LeftBat;
        private Bat RightBat;

        public void MoveBall()
        {
            this.Ball.Move();
        }
    }
}
