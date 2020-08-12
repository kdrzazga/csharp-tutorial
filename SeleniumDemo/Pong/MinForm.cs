using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class MinForm : Form
    {
        bool isLUpPressed, isLDownPressed, isRUpPressed, isRDownPressed;
        Ball ball;
        public MinForm()
        {
            InitializeComponent();
            ball = new Ball(aBall, this, new int[] { 0, ClientRectangle.Width, ClientRectangle.Height, 0}, 2, 2);
            MouseWheel += OnMouseWheelMove; 

        }
        /// <summary>
        /// Update x&y-speeds
        /// </summary>
        /// <param name="sender">MainForm</param>
        /// <param name="e">MouseEventArgs</param>
        private void OnMouseWheelMove(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                ball.xSpeed = ((ball.xSpeed) % 3) + Math.Sign(ball.xSpeed);
            else
                ball.ySpeed = ((ball.ySpeed) % 3) + Math.Sign(ball.ySpeed);
        }
        /// <summary>
        /// Move bats according to key states, move ball according to x&y-speeds and update speed display
        /// </summary>
        /// <param name="sender">Timer mainloop</param>
        /// <param name="e">EventArgs</param>
        private void mainloop_Tick(object sender, EventArgs e)
        {
            if (isLUpPressed)     //move bats
                lBat.Top--;
            if (isLDownPressed)
                lBat.Top++;
            if (isRUpPressed)
                rBat.Top--;
            if (isRDownPressed)
                rBat.Top++;
            ball.Move();          //move ball
            Text = $"Pong - ySpeed: {ball.ySpeed}; xSpeed: {ball.xSpeed}"; //update spped
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
        /// <summary>
        /// Update key states of key press and hold down
        /// </summary>
        /// <param name="sender">MainForm</param>
        /// <param name="e">KeyEventArgs</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                isLUpPressed = true;
            if (e.KeyCode == Keys.S)
                isLDownPressed = true;
            if (e.KeyCode == Keys.Up)
                isRUpPressed = true;
            if (e.KeyCode == Keys.Down)
                isRDownPressed = true;
        }
        /// <summary>
        /// Update key states on key release
        /// </summary>
        /// <param name="sender">KeyEventArgs</param>
        /// <param name="e">MainForm</param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                isLUpPressed = false;
            if (e.KeyCode == Keys.S)
                isLDownPressed = false;
            if (e.KeyCode == Keys.Up)
                isRUpPressed = false;
            if (e.KeyCode == Keys.Down)
                isRDownPressed = false;
        }
    }
}
