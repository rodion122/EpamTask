using System;
using System.Linq;

namespace Task.BLL.GeometryFigure
{
    class Trapeze : GeometricFigureWithSides
    {
        private void setOrderSides()
        {
            double[] result = new double[4];
            Points[] helper = new Points[2];

            helper = arrPoints.Where(j => j.Y == arrPoints.Max(i => i.Y)).ToArray();
            result[0] = Math.Sqrt(Math.Abs((helper[0].X * helper[0].X - helper[1].X * helper[1].X) + (helper[0].Y * helper[0].Y - helper[1].Y * helper[1].Y)));
            
            helper = arrPoints.Where(j => j.Y == arrPoints.Min(i => i.Y)).ToArray();
            result[1] = Math.Sqrt(Math.Abs((helper[0].X * helper[0].X - helper[1].X * helper[1].X) + (helper[0].Y * helper[0].Y - helper[1].Y * helper[1].Y)));

            arrPoints = arrPoints.OrderBy(i => i.X).ToArray();
            helper[0] = arrPoints[0];
            helper[1] = arrPoints[1];
            result[2] = Math.Sqrt(Math.Abs((helper[0].X * helper[0].X - helper[1].X * helper[1].X) + (helper[0].Y * helper[0].Y - helper[1].Y * helper[1].Y)));

            arrPoints = arrPoints.Reverse().ToArray();
            helper[0] = arrPoints[0];
            helper[1] = arrPoints[1];
            result[3] = Math.Sqrt(Math.Abs((helper[0].X * helper[0].X - helper[1].X * helper[1].X) + (helper[0].Y * helper[0].Y - helper[1].Y * helper[1].Y)));

            figureSides = result;
        }

        public Trapeze()
        {
            figureSides = null;
        }

        public override double GetArea()
        {
            //  нужно конкретные стороны :
            // a - верх == 0
            // b - низ == 1 
            // c - лево == 2
            // d - право == 3
            setOrderSides();
            return ((figureSides[0] + figureSides[1]) / 2 ) * Math.Sqrt(figureSides[2] * figureSides[2] - Math.Pow(((figureSides[1] - figureSides[0]) * (figureSides[1] - figureSides[0]) + figureSides[2] * figureSides[2] - figureSides[3] * figureSides[3]) / (2 * (figureSides[1] - figureSides[0])), 2));
        }

        protected override void setArrFigureSides()
        {
            figureSides = new double[4];
        }
    }
}