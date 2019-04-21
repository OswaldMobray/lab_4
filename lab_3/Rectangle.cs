using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Rectangle
    {
        int yPosition;
        int width;
        int height;
        Color color;
        public Rectangle(int randYPosition, int randomWidth, int randomHeight, Color randomColor)
        {
            this.yPosition = randYPosition;
            this.width = randomWidth;
            this.height = randomHeight;
            this.color = randomColor;
        }
        public void setYPosition(int randY)
        {
            this.yPosition = randY;
        }
        public int getYPosition()
        {
            return this.yPosition;
        }
        public void setColor(Color randomColor)
        {
            this.color = randomColor;
        }
        public Color getColor()
        {
            return this.color;
        }
        public void setHeight(int randHeight)
        {
            this.height = randHeight;
        }
        public int getHeight()
        {
            return this.height;
        }
        public void setWidth(int randWidth)
        {
            this.height = randWidth;
        }
        public int getWidth()
        {
            return this.width;
        }
    }
}
