using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceCalculatorLib;

namespace TestSpaceCalculator.FiguresTests
{
    [TestClass]
    public class PolygonTests
    {
        [TestMethod]
        public void TestGetPolygonSpace()
        {
            Polygon polygon = new Polygon();
            double expected = 13.5;
            polygon.Vertices.AddLast(new Vertice(0, 0));
            polygon.Vertices.AddLast(new Vertice(4, 2));
            polygon.Vertices.AddLast(new Vertice(3, 7));
            polygon.Vertices.AddLast(new Vertice(1, 4));
            polygon.Vertices.AddLast(new Vertice(0, 0));

            double actual = polygon.CalculateSpace();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void TestGetPolygonSpaceException()
        {
            Polygon polygon = new Polygon();
            polygon.Vertices.AddLast(new Vertice(0, 0));
            polygon.Vertices.AddLast(new Vertice(4, 2));
            polygon.Vertices.AddLast(new Vertice(3, 7));
            polygon.Vertices.AddLast(new Vertice(-2, 4));
            polygon.Vertices.AddLast(new Vertice(0, 0));

            double actual = polygon.CalculateSpace();
        }
    }
}
