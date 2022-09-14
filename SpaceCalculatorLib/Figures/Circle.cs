using System;
using System.Collections.Generic;

namespace SpaceCalculatorLib
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public override List<double> Edges { get; set; }
        public override LinkedList<Vertice> Vertices { get; set; }



        /// <param name="r">Радиус окружности</param>
        public Circle( double r)
        {
            Radius = r;
        }

        public Circle()
        {
            Radius = 0;
            Vertices = new LinkedList<Vertice>();
        }

        public override double CalculateSpace()
        {
            if (Radius <= 0 && (Vertices.Count >=360 || Vertices.Count == 0))
                throw new Exception("Не задан радиус либо он меньше 0.");
            // так же можно использовать Math.PI * Radius * Radius;
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateSpace(double radius)
        {
            Radius = radius;
            return CalculateSpace();
            
        }
    }
}
