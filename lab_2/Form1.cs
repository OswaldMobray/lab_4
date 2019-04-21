using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        private double xPosition;
        private double yPosition;
        private double angle;
        private int speed;
        private double xcoordMoveAway;
        private double ycoodMoveAway;
        private int widthField = 800;
        private int heightField = 452;
        private int maxXPosition = 780;
        private int minXPosition = 20;
        private int maxYPosition = 432;
        private int minYPosition = 10;
        private int widthRect = 20;
        private int heightRect = 20;
        private int minRandX = 10;
        private int minRandY = 10;
        private int maxRandX = 790;
        private int maxRandY = 442;
        private int maxRandAngle = 90;

        public Form1()
        {
            InitializeComponent();
        }

        public double Angle { get => angle; set => angle = value; }
        public double YPosition { get => yPosition; set => yPosition = value; }
        public double XPosition { get => xPosition; set => xPosition = value; }
        public int Speed { get => speed; set => speed = value; }
        public double xCoordMoveAway { get => xcoordMoveAway; set => xcoordMoveAway = value; }
        public double yCoordMoveAway { get => ycoodMoveAway; set => ycoodMoveAway = value; }

        private void show_btn_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Random random = new Random();

            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(Pens.Black, 0, 0, widthField, heightField);
            Speed = 4;
            XPosition = random.Next(minRandX, maxRandX);
            YPosition = random.Next(minRandY, maxRandY);
            Angle = random.Next(0, maxRandAngle);

            xCoordMoveAway = Speed * Math.Cos(Angle);
            yCoordMoveAway = Speed * Math.Sin(Angle);
            while (true)
            {
                g.Clear(this.BackColor);
                g.FillRectangle(Brushes.Black, Convert.ToInt32(Math.Round(XPosition)), Convert.ToInt32(Math.Round(YPosition)), widthRect, heightRect);
                g.DrawRectangle(pen, Convert.ToInt32(Math.Round(XPosition)), Convert.ToInt32(Math.Round(YPosition)), widthRect, heightRect);

                XPosition += xCoordMoveAway;
                YPosition += yCoordMoveAway;

                if (XPosition < minXPosition)
                {
                    xCoordMoveAway = -xCoordMoveAway;
                }
                if (XPosition > maxXPosition) xCoordMoveAway = -xCoordMoveAway;
                if (YPosition < minYPosition) yCoordMoveAway = -yCoordMoveAway;
                if (YPosition > maxYPosition) yCoordMoveAway = -yCoordMoveAway;
                Thread.Sleep(15);
                Application.DoEvents();
            }
        }
    }
}

