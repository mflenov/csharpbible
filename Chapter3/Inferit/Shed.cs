using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Shed : Building
    {
        public Shed() : this(1, 1, 1)
        {
        }

        public Shed(int w, int l, int height)
        {
            Width = w;
            Lengthwise = l;
            this.Height = height;
        }

        public int GetSize()
        {
            int size = Width * Height * Lengthwise;
            return size;
        }
    }
}
