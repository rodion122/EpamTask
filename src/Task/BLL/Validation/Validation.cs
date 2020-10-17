using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL
{
    class Validation
    {
        private Intersections checkIntersection = new Intersections();
        private Info infomration = new Info();

        public static bool IsValidInputData(string arrData)
        {
            string[] testArr = arrData.Trim().Split(' ').ToArray();
            for (int i = 0; i < testArr.Length; i++)
                if (!double.TryParse(testArr[i], out double value))
                    return false;

            if (testArr.Length < 3)
                return false;

            if (testArr.Length != 3)
            {
                if (testArr.Length % 2 != 0)
                    return false;

                int cointer = 0;
                int i2 = 1;
                int j2 = 1;
                for (int i = 0; i < testArr.Length -1; i+=2, i2 +=2)
                {
                    cointer = 0;
                    i2 = 1;
                    j2 = 1;
                    for (int j = 0; j < testArr.Length - 1; j += 2, j2 += 2)
                    {
                        if (testArr[i] == testArr[j] && testArr[i2] == testArr[j2])
                            cointer++;
                    }
                    if (cointer > 1)
                        return false;
                }
            }
            return true;
        }

        public static bool TryParseData(string arrData, out double[] arrValidData)
        {
            if (IsValidInputData(arrData))
            {
                arrValidData = arrData.Trim().Split(' ').Select(double.Parse).ToArray();
                return true;
            }
            else
            {
                arrValidData = null;
                return false;
            }
        }

        public bool IsValidCircle(double[] coords)
        {
            if (coords.Length != 3)
                return false;

            if (coords[2] <= 0)
                return false;
           
            return true;
        }

        public bool IsValidTriangle(double[] coords)
        { 
            if (coords.Length != 6)
                return false;
            
            Triangle triangle = new Triangle();
            triangle.SerArrPoints(coords.Where(i => Array.IndexOf(coords, i) % 2 == 0).ToArray(), coords.Where(i => Array.IndexOf(coords, i) % 2 != 0).ToArray());
            double[] siedesTriangle = triangle.GetFigureSides();
            double result = 0;
            for (int i = 0; i < siedesTriangle.Length; i++)
            {
                result = 0;
                for (int j = 0; j < siedesTriangle.Length; j++)
                    if (j != i)
                        result += siedesTriangle[j];
                if (siedesTriangle[i] < result)
                    return true;
            }

            return false;
        }

        public bool IsLinesInThisFigureIntersection(double[] coords)
        {
            Points[] points = new Points[coords.Length / 2];
            for (int i = 0; i < coords.Length; i += 2)
            {
                points[i] = new Points();
                points[i].X = coords[i];
                points[i].Y = coords[i + 1];
            }

            //for (int i = 0; i < length; i += 2)
            //{
            //    for (int j = 0; j < length; j++)
            //    {

            //    }
            //}
                //if (IsLinesIntersection(points[i], points[i + 1], points[i + 2], points[i + 3]))
                //    return true;

            return false;
        }

        public bool IsLinesIntersection(Points firstBegin, Points firstEnd, Points secondBegin, Points secondEnd)
        {
            Points cross = new Points();
           return checkIntersection.LineLine(firstBegin, firstEnd, secondBegin, secondEnd,out cross,out infomration);
        }
    }
}