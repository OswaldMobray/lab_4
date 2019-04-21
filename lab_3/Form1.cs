using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        private int rectWidth;
        private List<Rectangle> rects;
        public int xPosRect = -58;
        public int randForRed = 1;
        public int randForGreen = 1;
        public int randForBlue = 256;
        public const int xAddPosRect = 58;


        public Form1()
        {
            InitializeComponent();
        }

        public List<Rectangle> Rects { get => rects; set => rects = value; }
        public int RectWidth { get => rectWidth; set => rectWidth = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rectangle> sortedRects = Rects;
            sortedRects.Sort((firstBlock, secondBlock) => firstBlock.getHeight().CompareTo(secondBlock.getHeight()));
            DrawRects(sortedRects);
        }

        private void DrawRects(List<Rectangle> list)
        {
            var g = CreateGraphics();
            g.Clear(Color.White);
           
            for (int i = 0; i < 10; i++)
            {
                Brush brush = new SolidBrush(list[i].getColor());

                g.FillRectangle(brush, xPosRect += xAddPosRect, list[i].getYPosition(), list[i].getWidth(), list[i].getHeight());
                g.DrawRectangle(Pens.Black, xPosRect, list[i].getYPosition(), list[i].getWidth(), list[i].getHeight());

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RectWidth = this.ClientSize.Width / 20;
            Random rand = new Random();
            Rects = new List<Rectangle>();

            int xPosition = 0;
            for (int i = 0; i < 10; i++)
            {
                int height = rand.Next(1, this.ClientSize.Height);
                int yPosition = this.ClientSize.Height - height;
                Color randomColor = Color.FromArgb(rand.Next(randForRed), rand.Next(randForGreen), rand.Next(randForBlue));

                Rectangle temp = new Rectangle(yPosition, RectWidth, height, randomColor);
                Rects.Add(temp);
                xPosition += RectWidth;
            }
            Shown += ShownForm;
        }

        private void ShownForm(object sender, EventArgs e)
        {
            DrawRects(Rects);
        }

    }
}
