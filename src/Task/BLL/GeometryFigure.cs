using System;

namespace Task.BLL
{
    abstract class GeometryFigure
    {
        protected Points[] arrPoints;

        public void SerArrPoints(double[] arrPointsX, double[] arrPointsY)
        {
            if (arrPointsX == null || arrPointsY == null || arrPointsX.Length != arrPointsY.Length)
                throw new ArgumentNullException();

            arrPoints = new Points[arrPointsX.Length];
            for (int i = 0; i < arrPoints.Length; i++)
            {
                arrPoints[i].X = arrPointsX[i];
                arrPoints[i].Y = arrPointsY[i];
            }
        }

        public string TypeFigure { get; set; }

        abstract public double GetPerimeter();

        abstract public double GetArea();
    }
}