using System;

namespace Task.BLL.GeometryFigure
{
    class Parallelogram : GeometricFigureWithSides
    {
        public Parallelogram()
        {
            TypeFigure = "Parallelogram";
            figureSides = null;
        }

        public override double GetArea()
        {
            return Math.Sin(Math.Acos(WorkWithCoords.GetCosBetweenTwoLine(arrPoints[0], arrPoints[1], arrPoints[1], arrPoints[2]))) * figureSides[0]  * figureSides[1];
        }
    }
}