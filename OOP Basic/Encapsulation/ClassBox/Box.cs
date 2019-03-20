using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double Height   
        {
            get { return this.height; }
            set { this.height = value; }
        }



        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }


        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }


        public double GetLateralSurfaceArea()
        {
            return this.Length * this.Height * 2 + this.Width * this.Height * 2;
        }

        public double GetSurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double GetVolume()
        {
            return this.Height * this.Length * this.Width;
        }

    }
}
