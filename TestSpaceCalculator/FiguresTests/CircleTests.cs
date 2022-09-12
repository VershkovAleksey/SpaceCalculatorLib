using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceCalculatorLib;
using System;

namespace TestSpaceCalculator
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestGetSpaceCircle()
        {
            double radius = 5;
            double expected = Math.Pow(radius, 2) * Math.PI;

            Circle circle = new Circle();
            double actual = circle.GetCircleSpace(radius);
            Assert.AreEqual(expected, actual, "Площадь с заданным радиусом вычислена неправильно.");
        }
        [TestMethod]
        public void TestGetSpaceCircle1()
        {
            Circle circle = new Circle();
            circle.Radius = 7;
            double expected = Math.Pow(circle.Radius, 2) * Math.PI;
            double actual = circle.GetCircleSpace();
            Assert.AreEqual(expected, actual, "Площадь методом без перегрузки вычислена непавильно.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGetSpaceCircle2()
        {
            Circle circle = new Circle();
            circle.GetCircleSpace(0);
        }
    }
}
