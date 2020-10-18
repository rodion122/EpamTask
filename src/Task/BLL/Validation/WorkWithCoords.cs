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

        public static bool IsLinesMatch(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2)
                return true;
            return false;
        }

        public static Points GetPointWhereWasMatch(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            Points result = new Points();
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            result.X = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
            result.Y = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);
            return result;
        }

        public static bool ThisFigureNotHaveMathc(Points[] arrPoints)
        {
            for (int i = 0; i < arrPoints.Length - 1; i++)
            {
                if (i + 1 == arrPoints.Length)
                { 
                    for (int j = 0; j < arrPoints.Length - 1; j++)
                    {
                        if (j + 1 == arrPoints.Length)
                            if (IsLinesMatch(arrPoints[i], arrPoints[0], arrPoints[j], arrPoints[0]))
                            {
                                Points check = GetPointWhereWasMatch(arrPoints[i], arrPoints[0], arrPoints[j], arrPoints[0]);
                                for (int k = 0; k < arrPoints.Length; k++)
                                    if (arrPoints[k].X != check.X && arrPoints[k].Y != check.Y && !double.IsNaN(check.X) && double.IsNaN(check.Y))
                                        return false;
                            }
                        if (IsLinesMatch(arrPoints[i], arrPoints[i + 1], arrPoints[j], arrPoints[j + 1]))
                        {
                            Points check = GetPointWhereWasMatch(arrPoints[i], arrPoints[i + 1], arrPoints[j], arrPoints[j + 1]);
                            for (int k = 0; k < arrPoints.Length; k++)
                                if (arrPoints[k].X != check.X && arrPoints[k].Y != check.Y && !double.IsNaN(check.X) && double.IsNaN(check.Y))
                                    return false;
                        }
                    }
                }

                else
                    for (int j = 0; j < arrPoints.Length; j++)
                    {
                        if (j + 1 == arrPoints.Length)
                        {
                            if (IsLinesMatch(arrPoints[i], arrPoints[i + 1], arrPoints[j], arrPoints[0]))
                            {
                                Points check = GetPointWhereWasMatch(arrPoints[i], arrPoints[i + 1], arrPoints[j], arrPoints[0]);
                                for (int k = 0; k < arrPoints.Length; k++)
                                    if (arrPoints[k].X != check.X && arrPoints[k].Y != check.Y && !double.IsNaN(check.X) && double.IsNaN(check.Y))
                                        return false;
                            }
                        }
                        else
                        {
                            if (IsLinesMatch(arrPoints[i], arrPoints[i + 1], arrPoints[j], arrPoints[j + 1]))
                            {
                                Points check = GetPointWhereWasMatch(arrPoints[i], arrPoints[i + 1], arrPoints[j], arrPoints[j + 1]);
                                for (int k = 0; k < arrPoints.Length; k++)
                                    if (arrPoints[k].X != check.X && arrPoints[k].Y != check.Y && !double.IsNaN(check.X) && double.IsNaN(check.Y))
                                        return false;
                            }
                        }
                    }
            }
            return true;
        }

        public static double GetCosBetweenTwoLine(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            return (a1 * a2 + b1 * b2) / (Math.Sqrt(a1 * a1 + b1* b1) * Math.Sqrt(a2 * a2 + b2 * b2));
        }

        public static bool IsFigureOneLine(Points[] arrPoints)
        {
            int cointer = 0;
            for (int j = 0; j < arrPoints.Length; j++)
            {
                if (j + 1 == arrPoints.Length)
                {
                    if (IsLineParallel(arrPoints[0], arrPoints[1], arrPoints[j], arrPoints[0]))
                        cointer++;            
                }
                
                else
                {
                    if (IsLineParallel(arrPoints[0], arrPoints[1], arrPoints[j], arrPoints[j + 1]))
                        cointer++;
                }
            }
            if (cointer == arrPoints.Length)
                return true;

            return false;
        }
    }
}
