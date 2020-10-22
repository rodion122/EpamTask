using System;
using InteractionWithGeometricFugire.BLL;

namespace InteractionWithGeometricFugire.DAL.GeometryFigures
{
    class Trapeze : GeometricFigureWithSides
    {
        private void setOrderSides()
        {
            double[] result = new double[4];

            if(WorkWithCoords.IsLinesParallel(arrPoints[0], arrPoints[1], arrPoints[2], arrPoints[3]))
            {
                if(Math.Sqrt( Math.Pow(Math.Abs(arrPoints[0].X  - arrPoints[1].X), 2)  + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[1].Y), 2)) < Math.Sqrt(Math.Pow(Math.Abs(arrPoints[2].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[2].Y - arrPoints[3].Y), 2)))
                {
                    result[0] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[1].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[1].Y), 2));
                    result[1] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[2].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[2].Y - arrPoints[3].Y), 2));

                }
                else
                {
                    result[0] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[2].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[2].Y - arrPoints[3].Y), 2));
                    result[1] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[1].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[1].Y), 2));
                }
                result[2] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[1].X - arrPoints[2].X), 2) + Math.Pow(Math.Abs(arrPoints[1].Y - arrPoints[2].Y), 2));
                result[3] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[3].Y), 2));
            }

            else 
            {
                if (Math.Sqrt(Math.Pow(Math.Abs(arrPoints[1].X - arrPoints[2].X), 2) + Math.Pow(Math.Abs(arrPoints[1].Y - arrPoints[2].Y), 2)) < Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[3].Y), 2)))
                {
                    result[0] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[1].X - arrPoints[2].X), 2) + Math.Pow(Math.Abs(arrPoints[1].Y - arrPoints[2].Y), 2));
                    result[1] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[3].Y), 2));

                }
                else
                {
                    result[0] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[3].Y), 2));
                    result[1] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[1].X - arrPoints[2].X), 2) + Math.Pow(Math.Abs(arrPoints[1].Y - arrPoints[2].Y), 2));
                }
                result[2] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[0].X - arrPoints[1].X), 2) + Math.Pow(Math.Abs(arrPoints[0].Y - arrPoints[1].Y), 2));
                result[3] = Math.Sqrt(Math.Pow(Math.Abs(arrPoints[2].X - arrPoints[3].X), 2) + Math.Pow(Math.Abs(arrPoints[2].Y - arrPoints[3].Y), 2));
            }
            figureSides = result;
        }

        public Trapeze()
        {
            TypeFigure = "Trapeze";
        }

        public override double GetArea()
        {
            setOrderSides();
            return ((figureSides[0] + figureSides[1]) / 2 ) * Math.Sqrt(figureSides[2] * figureSides[2] - ( Math.Pow((((figureSides[1] - figureSides[0]) * (figureSides[1] - figureSides[0]) + figureSides[2] * figureSides[2] - figureSides[3] * figureSides[3]) / (2 * (figureSides[1] - figureSides[0]))), 2)));
        }
    }
}