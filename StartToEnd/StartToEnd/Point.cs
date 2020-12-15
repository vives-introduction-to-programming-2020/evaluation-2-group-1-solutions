using System;
using System.Collections.Generic;
using System.Text;

namespace StartToEnd
{
    public class Point
    {
        public Point(double x, double y)
        {
            SetX(x);
            SetY(y);
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        private double x = 0;
        private double y = 0;
    }
}
