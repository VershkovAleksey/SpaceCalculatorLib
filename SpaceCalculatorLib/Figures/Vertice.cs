using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCalculatorLib
{
    /// <summary>
    /// Класс описывает координаты вершины.
    /// </summary>
    public class Vertice
    {
        /// <summary>
        /// Координата по оси X
        /// </summary>
        public int PointX { get; set; }

        /// <summary>
        /// Координата по оси Y
        /// </summary>
        public int PointY { get; set; }

        public Vertice(int x, int y)
        {
            PointX = x;
            PointY = y;
        }
    }
}
