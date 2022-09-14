using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCalculatorLib
{
    /// <summary>
    /// Класс представляет абстрактную фигуру.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Ребра фигуры
        /// </summary>
        public abstract List<double> Edges { get; set; }
        /// <summary>
        /// Вершины фигуры
        /// </summary>
        public abstract LinkedList<Vertice> Vertices { get; set; }
        /// <summary>
        /// Метод подсчета площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double CalculateSpace();
    }
}
