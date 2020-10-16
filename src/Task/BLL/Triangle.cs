using System;

namespace Task.BLL
{
    class Triangle : GeometryFigure
    {
        private double[]  triangleSides;

        //public Triangle()
        //{
        //    triangleSides = null;
        //}

        public Triangle(double[] arrPoints)
        {
            if (arrPoints == null)
                throw new ArgumentNullException();

            triangleSides = new double[3];
            this.arrPoints = new Points[3];
            for (int i = 0; i < arrPoints.Length - 1; i++)
            {
                this.arrPoints[i].X = arrPoints[i];
                this.arrPoints[i].Y = arrPoints[i + 1];
                triangleSides[i] = Math.Sqrt((this.arrPoints[i + 1].X * this.arrPoints[i + 1].X - this.arrPoints[i].X * this.arrPoints[i + 1].X) + (this.arrPoints[i + 1].Y * this.arrPoints[i + 1].Y - this.arrPoints[i].Y * this.arrPoints[i].Y));
            }
        }

        public override double GetArea()
        {
            double halfPerimetr = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - triangleSides[0]) * (halfPerimetr - triangleSides[1]) * (halfPerimetr - triangleSides[2]));
        }

        public override double GetPerimeter()
        {
            if (arrPoints == null)
                throw new ArgumentNullException();

            double result = 0.0;
            for (int i = 0; i < arrPoints.Length - 1; i++)
                result += triangleSides[i];
            return result;
        }
    }
}
