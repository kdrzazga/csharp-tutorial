using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class PongForm : Form
    {
        public PongForm()
        {
            InitializeComponent();
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.playerView_Paint);
        }

        private void playerView_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the playerView.
            Graphics g = e.Graphics;
            //you can now draw using g

            //Left Wall 1
            Point lw1a = new Point(18, 7);
            Point lw1b = new Point(99, 61);
            Point lw1c = new Point(99, 259);
            Point lw1d = new Point(18, 313);

            Point[] lw1 = { lw1a, lw1b, lw1c, lw1d };

            //we need to dispose this pen when we're done with it.
            //a handy way to do that is with a "using" clause
            using (Pen pen = new Pen(Color.White, 1))
            {
                g.DrawPolygon(pen, lw1);
            }
        }

    }
}
