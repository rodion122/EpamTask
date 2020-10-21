using System;
using System.Linq;

namespace InteractionWithGeometricFugire.BLL
{
     public static class WorkWithCoords
     {
        private static double a1;
        private static double a2;
        private static double b1;
        private static double b2;
        private static double c1;
        private static double c2;

        private static bool isPointBelongsTwoLines(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd, Points chekedPoint)
        {
            double x1 = (pointSecondEnd.X - pointSecondStart.X) * (pointFirstStart.Y - pointSecondStart.Y) - (pointSecondEnd.Y - pointSecondStart.Y) * (pointFirstStart.X - pointSecondStart.X);
            double x2 = (pointSecondEnd.X - pointSecondStart.X) * (pointFirstEnd.Y - pointSecondStart.Y) - (pointSecondEnd.Y - pointSecondStart.Y) * (pointFirstEnd.X - pointSecondStart.X);
            double x3 = (pointFirstEnd.X - pointFirstStart.X) * (pointSecondStart.Y - pointFirstStart.Y) - (pointFirstEnd.Y - pointFirstStart.Y) * (pointSecondStart.X - pointFirstStart.X);
            double x4 = (pointFirstEnd.X - pointFirstStart.X) * (pointSecondEnd.Y - pointFirstStart.Y) - (pointFirstEnd.Y - pointFirstStart.Y) * (pointSecondEnd.X - pointFirstStart.X);
            return x1 * x2 < 0 && x3 * x4 < 0;
        }

        private static bool thisPointBelongFigurePoints(Points[] arrPoints, Points chekedPoint)
        {
            for (int i = 0; i < arrPoints.Length; i++)
                if (arrPoints[i].X == chekedPoint.X && arrPoints[i].Y == chekedPoint.Y)
                    return true;
            return false;
        }

        private static void setCoefficients(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            a1 = pointFirstEnd.Y - pointFirstStart.Y;
            b1 = pointFirstStart.X - pointFirstEnd.X;
            c1 = pointFirstStart.Y * pointFirstEnd.X - pointFirstStart.X * pointFirstEnd.Y;

            a2 = pointSecondEnd.Y - pointSecondStart.Y;
            b2 = pointSecondStart.X - pointSecondEnd.X;
            c2 = pointSecondStart.Y * pointSecondEnd.X - pointSecondStart.X * pointSecondEnd.Y;
        }

        public static bool IsLinesParallel(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            return (a1 * b2 == a2 * b1);
        }

        public static bool IsLineСoincide(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            return (a1 * c2 == a2 * c1 && b1 * c2 == b2 * c1);
        }

            public static bool IsLinePerpendicular(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            return (a1 * a2 + b1 * b2 == 0);
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
            int indexFitst, indexSecond, indexThird, indexFourth;
            for (int i = 0; i < arrPoints.Length; i++)
            {
                indexFitst = i;
                if (i + 1 == arrPoints.Length)
                    indexSecond = 0;
                else 
                    indexSecond = indexFitst + 1;
                   
                for (int j = 0; j < arrPoints.Length; j++)
                {
                    indexThird = j;
                    indexFourth = j + 1;
                    if (j + 1 == arrPoints.Length)
                        indexFourth = 0;
                    
                    if (IsLinesIntersect(arrPoints[indexFitst], arrPoints[indexSecond], arrPoints[indexThird], arrPoints[indexFourth]))
                    {
                        Points check = GetPointWhereWasMatch(arrPoints[indexFitst], arrPoints[indexSecond], arrPoints[indexThird], arrPoints[indexFourth]);
                        if (isPointBelongsTwoLines(arrPoints[indexFitst], arrPoints[indexSecond], arrPoints[j], arrPoints[indexFourth], check) && !thisPointBelongFigurePoints(arrPoints, check))
                            return false;
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
                    if (IsLinesParallel(arrPoints[0], arrPoints[1], arrPoints[j], arrPoints[0]))
                        cointer++;
                }
                else
                {
                    if (IsLinesParallel(arrPoints[0], arrPoints[1], arrPoints[j], arrPoints[j + 1]))
                        cointer++;
                }
            }
            return (cointer == arrPoints.Length);
        }

        public static bool IsLinesIntersect(Points pointFirstStart, Points pointFirstEnd, Points pointSecondStart, Points pointSecondEnd)
        {
            setCoefficients(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd);
            if(!IsLinesParallel(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd) && !IsLineСoincide(pointFirstStart, pointFirstEnd, pointSecondStart, pointSecondEnd))
                return true;
            return false;
        }
    }
}
