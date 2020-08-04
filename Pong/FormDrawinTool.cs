using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pong.GameElements;

namespace Pong
{
    class FormDrawinTool : IDrawingTool
    {
        private Graphics g;

        public FormDrawinTool(Graphics g)
        {
            this.g = g;
        }

        public void Draw(Board board)
        {
            g.Clear(Color.Aqua);
        }
    }
}
