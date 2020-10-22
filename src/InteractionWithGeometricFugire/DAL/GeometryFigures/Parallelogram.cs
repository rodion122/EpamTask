using System;
using InteractionWithGeometricFugire.BLL;

namespace InteractionWithGeometricFugire.DAL.GeometryFigures
{
    class Parallelogram : GeometricFigureWithSides
    {
        public Parallelogram()
        {
            TypeFigure = "Parallelogram";
        }

        public override double GetArea()
        {
            return Math.Sin(Math.Acos(WorkWithCoords.GetCosBetweenTwoLine(arrPoints[0], arrPoints[1], arrPoints[1], arrPoints[2]))) * figureSides[0]  * figureSides[1];
        }
    }
}