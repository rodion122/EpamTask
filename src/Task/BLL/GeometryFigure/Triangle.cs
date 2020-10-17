using System;

namespace Task.BLL
{
    class Triangle : GeometricFigureWithSides
    {
        public Triangle()
        {
            figureSides = null;
        }

        public override double GetArea()
        {
            double halfPerimetr = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - figureSides[0]) * (halfPerimetr - figureSides[1]) * (halfPerimetr - figureSides[2]));
        }

        protected override void setArrFigureSides()
        {
            figureSides = new double[3];   
        }
    }
}