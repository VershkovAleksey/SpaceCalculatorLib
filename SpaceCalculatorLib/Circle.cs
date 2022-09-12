using System;

namespace SpaceCalculatorLib
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        /// <summary>
        /// Метод подсчета площади окружности
        /// </summary>
        /// <returns>Площадь окружности</returns>
        public double GetCircleSpace()
        {
            if(Radius <= 0)
                throw new Exception("Не задан радиус либо он меньше 0.");
            // так же можно использовать Math.PI * Radius * Radius;
            return Math.PI * Math.Pow(Radius, 2);
        }
        /// <summary>
        /// Метод подсчета площади окружности.
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns>Площадь окружности</returns>
        public double GetCircleSpace(double radius)
        {
            Radius = radius;
            return GetCircleSpace();
        }
    }
}
