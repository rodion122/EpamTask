using System;

namespace Task.BLL
{
    class Triangle : GeometryFigure
    {
        private double[]  triangleSides;

        private void setTriangleSides()
        {
            triangleSides = new double[2];
            int j = 0;
            for (int i = 0; i < arrPoints.Length; i += 2)
            {
                triangleSides[j] = Math.Sqrt((arrPoints[i + 1].X * arrPoints[i + 1].X - arrPoints[i].X * arrPoints[i + 1].X) + (arrPoints[i + 1].Y * arrPoints[i + 1].Y - arrPoints[i].Y * arrPoints[i].Y));
                j++;
            }
        }

        public Triangle()
        {
            triangleSides = null;
        }

        public double[] TriangleSides { get => triangleSides; }

        public override double GetArea()
        {
            double halfPerimetr = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - triangleSides[0]) * (halfPerimetr - triangleSides[1]) * (halfPerimetr - triangleSides[2]));
        }

        public override double GetPerimeter()
        {
            if (arrPoints == null)
                throw new ArgumentNullException();

            if (triangleSides == null)
                setTriangleSides();

            double result = 0.0;
            for (int i = 0; i < arrPoints.Length - 1; i++)
                result += triangleSides[i];
            return result;
        }
    }
}