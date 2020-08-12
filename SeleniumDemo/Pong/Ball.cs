using System.Windows.Forms;
using System.Drawing;
using System;

namespace Pong
{
    internal class Ball
    {
        #region Private fields
        private Panel ball;
        private int _xSpeed;
        private int _ySpeed;
        private MinForm parent;
        private int[] canvasBoundaries;
        #endregion
        #region Public Properties
        public int xSpeed
        {
            get { return _xSpeed; }
            set { _xSpeed = value; }
        }
        public int ySpeed
        {
            get { return _ySpeed; }
            set { _ySpeed = value; }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="ball">A panel that represents a ball on the winform</param>
        /// <param name="parent">A parent window form.</param>
        /// <param name="canvasBoundaries">size of the canvas where (0, 0) is top left</param>
        /// <param name="xSpeed">The speed value on the X axis</param>
        /// <param name="ySpeed">The speed value on the Y axis</param>
        public Ball(Panel ball, MinForm parent, int[] canvasBoundaries, int xSpeed = 1, int ySpeed = 1)
        {
            this.ball = ball;
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
            this.canvasBoundaries = canvasBoundaries;
            this.parent = parent;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Move the ball and update the sign of x&y-speeds if a collision is detected. 
        /// </summary>
        public void Move()
        {
            //Move ball
            ball.Location = new Point(
                Math.Max(canvasBoundaries[3], Math.Min(canvasBoundaries[1] - ball.Width,  ball.Location.X + _xSpeed)),
                Math.Max(canvasBoundaries[0], Math.Min(canvasBoundaries[2] - ball.Height, ball.Location.Y + _ySpeed))
                );
            if (ball.Location.Y == canvasBoundaries[0] || ball.Location.Y == canvasBoundaries[2] - ball.Height)
                _ySpeed *= -1; //update the sign of ySpeed if a collision is detected
            if (ball.Location.X == canvasBoundaries[3] || ball.Location.X == canvasBoundaries[1] - ball.Width)
            {
                _xSpeed *= -1; //update the sign of xSpeed if a collision is detected
                if (ball.Location.X != canvasBoundaries[3]) //update score
                    parent.lScore_lbl.Text = ((int.Parse(parent.lScore_lbl.Text) + 1)%10).ToString();
                else
                    parent.rScore_lbl.Text = ((int.Parse(parent.rScore_lbl.Text) + 1)%10).ToString();
            }
            if (ball.Location.Y > parent.lBat.Location.Y && ball.Location.Y < parent.lBat.Location.Y + parent.lBat.Height && ball.Location.X <= parent.lBat.Location.X + parent.lBat.Width)
                _xSpeed *= -1; //update the sign of xSpeed if a collision is detected
            if (ball.Location.Y > parent.rBat.Location.Y && ball.Location.Y < parent.rBat.Location.Y + parent.rBat.Height && ball.Location.X >= parent.rBat.Location.X - parent.rBat.Width)
                _xSpeed *= -1; //update the sign of ySpeed if a collision is detected
        }
        #endregion
    }
}