using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCalculatorLib
{
    public class Vertice
    {
        public int PointX { get; set; }
        public int PointY { get; set; }

        public Vertice(int x, int y)
        {
            PointX = x;
            PointY = y;
        }
    }
}
