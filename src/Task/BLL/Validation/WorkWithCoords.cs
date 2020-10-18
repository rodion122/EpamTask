using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.Validation
{
    static class WorkWithCoords
    {
        private static double a1;
        private static double a2;
        private static double b1;
        private static double b2;
        private static double c1;
        private static double c2;

        private static void setCoefficients(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            a1 = pointFirstEnd.Y - pointFirstStart.Y;
            b1 = pointFirstStart.X - pointFirstEnd.X;
            c1 = pointFirstStart.Y * pointFirstEnd.X - pointFirstStart.X * pointFirstEnd.Y;

            a2 = pointSecondEnd.Y - pointSecondStart.Y;
            b2 = pointSecondStart.X - pointSecondEnd.X;
            c2 = pointSecondStart.Y * pointSecondEnd.X - pointSecondStart.X * pointSecondEnd.Y;
        }

        public static bool IsLineParallel(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            if (a1 * b2 == a2 * b1)
                return true;
            return false;
        }

        public static bool IsLinePerpendicular(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            if (a1 * a2 + b1 * b2 == 0)
                return true;
            return false;
        }
    }
}
