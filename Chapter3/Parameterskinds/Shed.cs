using System;
using System.Collections.Generic;
using System.Text;

namespace MethodParameters
{
    class Shed
    {
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

        public void ExpandSize(int x, int y, int h)
        {
            Width += x;
            Lengthwise += y;
            Height += h;
        }

        public void ExpandAndGetSize(ref int x, ref int y, ref int h)
        {
            ExpandSize(x, y, h);
            x = Width;
            y = Lengthwise;
            h = Height;
        }

        public void ExpandAndGetSize2(int inc, out int x, out int y, out int h)
        {
            ExpandSize(inc, inc, inc);
            x = Width;
            y = Lengthwise;
            h = Height;
        }
    }
}
