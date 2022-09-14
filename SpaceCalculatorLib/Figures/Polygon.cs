﻿using System;
using System.Collections.Generic;

namespace SpaceCalculatorLib
{
    public class Polygon : Figure
    {
        public override List<double> Edges { get; set; }
        public override LinkedList<Vertice> Vertices { get; set; }
        public Polygon(List<double> edges, LinkedList<Vertice> vertices)
        {
            Edges = edges;
            Vertices = vertices;
        }

        public Polygon()
        {
            Vertices = new LinkedList<Vertice>();
            Edges = new List<double>();
        }

        public override double CalculateSpace()
        {
            double space = 0;
            LinkedListNode<Vertice> vertice = Vertices.First;
            for (int i = 0; i < Vertices.Count - 1; i++)
            {
                if (vertice.Value.PointX < 0 || vertice.Value.PointY < 0)
                    throw new ArithmeticException("Значения на координатной плоскости должны быть больше нуля.");
                space += 0.5 * Math.Abs(vertice.Value.PointX + vertice.Next.Value.PointX) * (vertice.Value.PointY - vertice.Next.Value.PointY);
                vertice = vertice.Next;
            }
            return Math.Abs(space);
        }

    }
}
