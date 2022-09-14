using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCalculatorLib
{
    /// <summary>
    /// Класс предоставляет свойства и методы для работы с треугольником. Наследуется от абстрактного класса Figure.
    /// </summary>
    public class Triangle : Figure
    {
        public override List<double> Edges { get; set; }
        public override LinkedList<Vertice> Vertices { get; set; }
        public Triangle()
        {
            Edges = new List<double>();
        }

        public override double CalculateSpace()
        {
            if (Edges.Count == 3)
            {
                double edgeA, edgeB, edgeC = 0;
                edgeA = Edges[0];
                edgeB = Edges[1];
                edgeC = Edges[2];
                double semiPerimetr = 0;
                foreach (double edge in Edges)
                {
                    if (edge <= 0)
                        throw new Exception("Стороны должны быть больше нуля.");
                    semiPerimetr += edge;
                }
                semiPerimetr /= 2;
                return Math.Sqrt(semiPerimetr * (semiPerimetr - edgeA) * (semiPerimetr - edgeB) * (semiPerimetr - edgeC));
            }
            else
                throw new Exception("У треугольника 3 стороны.");
        }


        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина второй стороны</param>
        /// <param name="thirdSide">Длина третьей стороны</param>
        public double CalculateSpace(double firstSide, double secondSide, double thirdSide)
        {
            Edges.Add(firstSide);
            Edges.Add(secondSide);
            Edges.Add(thirdSide);
            return CalculateSpace();
        }
        /// <summary>
        /// Метод проверки на прямоугольный треугольник
        /// </summary>
        /// <returns>true - если треугольник прямоугольный. false - если нет.</returns>
        public bool IsRightTriangle()
        {
            double sqrtFirstSide = Math.Pow(Edges[0], 2);
            double sqrtSecondSide = Math.Pow(Edges[1], 2);
            double sqrtThirdSide = Math.Pow(Edges[2], 2);
            if (sqrtFirstSide + sqrtSecondSide == sqrtThirdSide || sqrtFirstSide + sqrtThirdSide == sqrtSecondSide || sqrtSecondSide + sqrtThirdSide == sqrtFirstSide)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Метод проверки на прямоугольный треугольник
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина второй стороны</param>
        /// <param name="thirdSide">Длина третьей стороны</param>
        /// <returns>true - если треугольник прямоугольный. false - если нет.</returns>
        public bool IsRightTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new Exception("Стороны должны быть больше нуля.");
            Edges.Add(firstSide);
            Edges.Add(secondSide);
            Edges.Add(thirdSide);
            return IsRightTriangle();
        }
    }
}
