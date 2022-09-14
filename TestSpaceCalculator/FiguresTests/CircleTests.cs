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
            double actual = circle.CalculateSpace(radius);
            Assert.AreEqual(expected, actual, "������� � �������� �������� ��������� �����������.");
        }
        [TestMethod]
        public void TestGetSpaceCircleOverload()
        {
            Circle circle = new Circle();
            circle.Radius = 7;
            double expected = Math.Pow(circle.Radius, 2) * Math.PI;
            double actual = circle.CalculateSpace();
            Assert.AreEqual(expected, actual, "������� ������� ��� ���������� ��������� ����������.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGetSpaceCircleException()
        {
            Circle circle = new Circle();
            circle.CalculateSpace(0);
        }
    }
}
