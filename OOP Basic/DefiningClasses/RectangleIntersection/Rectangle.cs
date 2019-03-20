using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    class Rectangle
    {
        private string id;
        private double wedth;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double weght, double height, double x, double y)
        {
            this.Id = id;
            this.Wedth = wedth;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Wedth
        {
            get { return wedth; }
            set { wedth = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        internal bool Intersect(Rectangle secondRectangle)
        {
            if (this.X + this.Wedth < secondRectangle.X ||
                secondRectangle.X + secondRectangle.Wedth < this.X ||
                this.Y + this.Height < secondRectangle.Y ||
                secondRectangle.Y + secondRectangle.Height < this.Y)
            {
                return false;
            }
            return true;
        }
    }
}
