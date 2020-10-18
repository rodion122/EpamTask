using Task.BLL.Validation;
using System;

namespace Task.BLL.GeometryFigure
{
    class Quadrangle : GeometricFigureWithSides
    {
        public Quadrangle()
        {
            TypeFigure = "Quadrangle";
            figureSides = null;
        }

        public override double GetArea()
        {
            return 0.5 * Math.Sin(Math.Acos(WorkWithCoords.GetCosBetweenTwoLine(arrPoints[0], arrPoints[2], arrPoints[1], arrPoints[3]))) * Math.Sqrt((Math.Pow(Math.Abs(arrPoints[3].X - arrPoints[1].X), 2)) + ((Math.Pow(Math.Abs(arrPoints[3].Y - arrPoints[1].Y), 2)))) * Math.Sqrt((Math.Pow(Math.Abs(arrPoints[2].X - arrPoints[0].X), 2)) + ((Math.Pow(Math.Abs(arrPoints[2].Y - arrPoints[0].Y), 2))));
        }
    }
}
