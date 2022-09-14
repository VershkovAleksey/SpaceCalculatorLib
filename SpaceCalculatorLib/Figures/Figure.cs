using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCalculatorLib
{
    public abstract class Figure
    {
        public abstract List<double> Edges { get; set; }
        public abstract LinkedList<Vertice> Vertices { get; set; }
        /// <summary>
        /// Метод подсчета площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateSpace();
    }
}
