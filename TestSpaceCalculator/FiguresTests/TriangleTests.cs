using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceCalculatorLib;

namespace TestSpaceCalculator
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestGetTriangleSpace()
        {
            Triangle triangle = new Triangle();
            triangle.Edges.Add(3);
            triangle.Edges.Add(4);
            triangle.Edges.Add(5);
            double expected = 6;
            double actual = triangle.CalculateSpace();

            Assert.AreEqual(expected, actual, "Площадь треугольника без параметров вычислена неправильно.");
        }

        [TestMethod]
        public void TestGetTriangleSpaceOverload()
        {
            Triangle triangle = new Triangle();

            double expected = 6;
            double actual = triangle.CalculateSpace(3, 4, 5);
            Assert.AreEqual(expected, actual, "Площадь треугольника по методу с параметрами вычислена неправильно.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGetTriangleSpaceException()
        {
            Triangle triangle = new Triangle();
            triangle.CalculateSpace(0, 4, 5);
        }

        [TestMethod]
        public void TestIsRightTriangle()
        {
            Triangle triangle = new Triangle();
            triangle.Edges.Add(3);
            triangle.Edges.Add(4);
            triangle.Edges.Add(5);
            Assert.IsTrue(triangle.IsRightTriangle(), "Проверка на прямой треугольник неверна.");
        }
        [TestMethod]
        public void TestIsRightTriangleOverload()
        {
            Triangle triangle = new Triangle();
            Assert.IsTrue(triangle.IsRightTriangle(3, 4, 5), "Проверка на прямой угол у метода с аргументами неверна.");
        }

    }
}
