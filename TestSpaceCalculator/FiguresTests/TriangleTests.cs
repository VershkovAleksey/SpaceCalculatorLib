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
            triangle.FirstSide = 3;
            triangle.SecondSide = 4;
            triangle.ThirdSide = 5;
            double semiPerimetr = (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide)/ 2;
            double expected = 6;
            double actual = triangle.GetTriangleSpace();

            Assert.AreEqual(expected, actual, "Площадь треугольника без параметров вычислена неправильно.");
        }

        [TestMethod]
        public void TestGetTriangleSpace1()
        {
            Triangle triangle = new Triangle();

            double expected = 6;
            double actual = triangle.GetTriangleSpace(3, 4, 5);
            Assert.AreEqual(expected, actual, "Площадь треугольника по методу с параметрами вычислена неправильно.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGetTriangleSpace2()
        {
            Triangle triangle = new Triangle();
            triangle.GetTriangleSpace(0, 4, 5);
        }

        [TestMethod]
        public void TestIsRightTriangle()
        {
            Triangle triangle = new Triangle();
            triangle.FirstSide = 3;
            triangle.SecondSide = 4;
            triangle.ThirdSide = 5;
            Assert.IsTrue(triangle.IsRightTriangle(), "Проверка на прямой треугольник неверна.");
        }
        [TestMethod]
        public void TestIsRightTriangle1()
        {
            Triangle triangle = new Triangle();
            Assert.IsTrue(triangle.IsRightTriangle(3, 4, 5), "Проверка на прямой угол у метода с аргументами неверна.");
        }

    }
}
