using System;

namespace InteractionWithGeometricFugire.DAL.GeometryFigures
{
    abstract class GeometricFigureWithSides : GeometryFigure
    {
        protected double[] figureSides;

        protected void setArrFigureSides()
        {
            figureSides = new double[arrPoints.Length];
        }

        protected void setFigureSides()
        {
            int j = 0;
            for (int i = 0; i < arrPoints.Length; i++)
            {
                if( i + 1 == arrPoints.Length)
                    figureSides[j] = Math.Sqrt((Math.Pow(Math.Abs(arrPoints[i].X - arrPoints[0].X),2)) + ((Math.Pow(Math.Abs(arrPoints[i].Y - arrPoints[0].Y), 2))));
                else
                    figureSides[j] = Math.Sqrt((Math.Pow(Math.Abs(arrPoints[i + 1].X - arrPoints[i].X), 2)) + ((Math.Pow(Math.Abs(arrPoints[i + 1].Y - arrPoints[i].Y), 2))));
                j++;
            }
        }

        public override double GetPerimeter()
        {
            double result = 0.0;
            for (int i = 0; i < figureSides.Length; i++)
                result += figureSides[i];
            return result;
        }

        public override void SerArrPoints(double[] arrPoints)
        {
            if (arrPoints == null)
                throw new ArgumentNullException();

            this.arrPoints = new Points[arrPoints.Length / 2];
            int cointer = 0;
            for (int i = 0; i < arrPoints.Length; i += 2)
            {
                this.arrPoints[cointer] = new Points();
                this.arrPoints[cointer].X = arrPoints[i];
                this.arrPoints[cointer].Y = arrPoints[i + 1];
                cointer++;
            }
            setArrFigureSides();
            setFigureSides();
        }
        
        public double[] GetFigureSides() => figureSides;
    }
}
