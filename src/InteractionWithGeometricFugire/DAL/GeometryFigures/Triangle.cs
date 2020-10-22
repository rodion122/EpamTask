using System;

namespace InteractionWithGeometricFugire.DAL.GeometryFigures
{
    class Triangle : GeometricFigureWithSides
    {
        public Triangle()
        {
            TypeFigure = "Triangle";
        }

        public override double GetArea()
        {
            double halfPerimetr = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - figureSides[0]) * (halfPerimetr - figureSides[1]) * (halfPerimetr - figureSides[2]));
        }
    }
}