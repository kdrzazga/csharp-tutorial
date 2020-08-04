using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pong.GameElements
{
    public class Game
    {
        private Board Board;
        private bool running;

        public Game()
        {
            while (true)
            {
                if (this.running)
                {
                    Console.Out.Write('.');
                }
                Thread.Sleep(40);
            }
        }

        public void Start()
        {
            this.running = true;
        }


        public void Stop()
        {
            this.running = false;
        }
    }
}
