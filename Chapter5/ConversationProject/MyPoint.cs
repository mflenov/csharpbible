using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversationProject
{
    class MyPoint
    {
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        int x;
        public int X 
        {
            get { return x; }
            set { x = value; }
        }

        int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return x.ToString() + ":" + y.ToString();
        }

        public static MyPoint operator *(MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X * p2.X, p1.Y * p2.Y);
        }

        public static MyPoint operator +(MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static MyPoint operator -(MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static bool operator < (MyPoint p1, MyPoint p2)
        {
            return (p1.X + p1.Y < p2.X + p2.Y);
        }

        public static bool operator >(MyPoint p1, MyPoint p2)
        {
            return (p1.X + p1.Y > p2.X + p2.Y);
        }

        public static implicit operator MyPoint(Person p)
        {
            return new MyPoint(p.X, p.Y);
        }
    }
}
