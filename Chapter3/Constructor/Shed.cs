using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Shed
    {
        public Shed(): this(1, 1, 1)
        {
        }

        public Shed(int w, int l, int height)
        {
            width = w;
            Lengthwise = l;
            this.height = height;
        }

        int width;
        int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Lengthwise { get; set; }


        // Метод, возвращающий размер сарая
        public int GetSize()
        {
            int size = width * height * Lengthwise;
            return size;
        }
    }
}
