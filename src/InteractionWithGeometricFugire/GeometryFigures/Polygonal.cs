﻿namespace InteractionWithGeometricFugire.GeometryFigures
{
    class Polygonal : GeometricFigureWithSides
    {
        public Polygonal()
        {
            TypeFigure = "Polygonal";
        }

        public override double GetArea()
        {
            double result = arrPoints[arrPoints.Length - 1].X * arrPoints[0].Y;
            for (int i = 0; i < arrPoints.Length - 1; i++)
                result += arrPoints[i].X * arrPoints[i + 1].Y;

            for (int i = 0; i < arrPoints.Length - 1; i++)
                result -= arrPoints[i + 1].X * arrPoints[i].Y;
            result -= arrPoints[0].X * arrPoints[arrPoints.Length - 1].Y;
            return System.Math.Abs(result * 0.5);
        }
    }
}