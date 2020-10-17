using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL
{
    class Validation
    {
        public bool IsValidInputData(string arrData)
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
                int cointerX = 0;
                int cointerY = 0;
                for (int i = 0; i < testArr.Length -1; i+=2, i2 +=2)
                {
                    cointer = 0;
                    i2 = 1;
                    j2 = 1;
                    cointerX = 0;
                    cointerY = 0;
                    for (int j = 0; j < testArr.Length - 1; j += 2, j2 += 2)
                    {
                        if (testArr[i] == testArr[j] && testArr[i2] == testArr[j2])
                            cointer++;

                        if (testArr[i] == testArr[j])
                            cointerX++;

                        if (testArr[i2] == testArr[j2])
                            cointerY++;
                    }
                    if (cointer > 1)
                        return false;

                    if (cointerX == testArr.Length / 2 || cointerY == testArr.Length / 2)
                        return false;
                }
            }
            return true;
        }

        public bool TryParseData(string arrData, out double[] arrValidData)
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

    }
}