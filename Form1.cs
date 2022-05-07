using System;
using Nakov.TurtleGraphics;
using System.Windows.Forms;

namespace TurtleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void DrawHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
            for (int i = 0; i < 6; i++)
            {
                Turtle.Delay = 200;
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void DrawStar_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
            for (int i = 0; i < 5; i++)
            {
                Turtle.Delay = 200;
                Turtle.Rotate(144);
                Turtle.Forward(200);
            }
        }

        private void DrawSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
            for (int i = 0; i < 20; i++)
            {
                Turtle.Delay = 200;
                Turtle.Rotate(60);
                Turtle.Forward(8 * i);
            }
        }

        private void DrawTriangles_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
            var step = 10;
            for (int i = 0; i < 22; i++)
            {
                step += 10;
                Turtle.Delay = 200;
                Turtle.Rotate(120);
                Turtle.Forward(step);
            }
        }
    }
}
