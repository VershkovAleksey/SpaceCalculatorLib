using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCalculatorLib
{
    public class Triangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle()
        {
            FirstSide = 0;
            SecondSide = 0;
            ThirdSide = 0;
        }
        /// <summary>
        /// Метод подсчета площади треугольника по трем сторонам
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetTriangleSpace()
        {
            if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0)
                throw new Exception("Стороны должны быть больше нуля.");
            double semiPerimetr = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - FirstSide) * (semiPerimetr - SecondSide) * (semiPerimetr - ThirdSide)); // Формула Герона
        }
        /// <summary>
        /// Метод подсчета площади треугольника по трем сторонам
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина второй стороны</param>
        /// <param name="thirdSide">Длина третьей стороны</param>
        /// <returns>Площадь треугольника</returns>
        public double GetTriangleSpace(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            return GetTriangleSpace();
        }
        /// <summary>
        /// Метод проверки на прямоугольный треугольник
        /// </summary>
        /// <returns>true - если треугольник прямоугольный. false - если нет.</returns>
        public bool IsRightTriangle()
        {
            double sqrtFirstSide = Math.Pow(FirstSide, 2);
            double sqrtSecondSide = Math.Pow(SecondSide, 2);
            double sqrtThirdSide = Math.Pow(ThirdSide, 2);
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
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            return IsRightTriangle();
        }
    }
}
