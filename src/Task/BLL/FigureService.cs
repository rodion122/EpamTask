﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL
{
    class FigureService
    {
        private Intersections checkIntersections = new Intersections();
        Info information = new Info();

        public string DefineFigure(double[] arrCoords)
        {
            if (arrCoords.Length == 3)
                return "Circle";

            if (arrCoords.Length == 6)
                return "Triangle";

            if(arrCoords.Length == 8)
            {
                Points[] points = new Points[arrCoords.Length / 2];
                int cointer = 0;
                for (int i = 0; i < arrCoords.Length; i += 2)
                {
                    points[cointer] = new Points();
                    points[cointer].X = arrCoords[i];
                    points[cointer].Y = arrCoords[i + 1];
                    cointer++;
                }
                // реализация определния конкретной фигуры...
                // ...

                return "Quadrangle";
            }

            if (arrCoords.Length > 8)
                return "Polygonal";

            return "None";
        }

        public void CheckIntersectionsInFigure(Points[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                }
            }
        }

    }
}