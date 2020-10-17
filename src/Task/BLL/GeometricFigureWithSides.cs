using System;

namespace Task.BLL
{
    abstract class GeometricFigureWithSides : GeometryFigure
    {
        protected double[] figureSides;

        protected void setFigureSides()
        {
            if (arrPoints == null)
                throw new ArgumentNullException();

            setArrFigureSides();
            int j = 0;
            for (int i = 0; i < arrPoints.Length; i += 2)
            {
                figureSides[j] = Math.Sqrt((arrPoints[i + 1].X * arrPoints[i + 1].X - arrPoints[i].X * arrPoints[i + 1].X) + (arrPoints[i + 1].Y * arrPoints[i + 1].Y - arrPoints[i].Y * arrPoints[i].Y));
                j++;
            }
        }

        public override double GetPerimeter()
        {
            if (figureSides == null)
                setFigureSides();

            double result = 0.0;
            for (int i = 0; i < figureSides.Length; i++)
                result += figureSides[i];
            return result;
        }

        abstract protected void setArrFigureSides();

        public double[] GetFigureSides() => figureSides;
    }
}
