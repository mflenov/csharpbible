using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPointProject
{
    class House
    {
        public House(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
