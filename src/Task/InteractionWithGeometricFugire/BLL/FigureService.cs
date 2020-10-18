using System;
using System.Collections.Generic;
using System.Linq;

namespace InteractionWithGeometricFugire.BLL
{
    public static class FigureService
    {
        public static string DefineFigure(double[] arrCoords)
        {
            if (arrCoords.Length == 3)
                return "Circle";

            if (arrCoords.Length == 6)
                return "Triangle";

            Points[] points = new Points[arrCoords.Length / 2];
            int cointer = 0;
            bool IsMetCondition = true;

            for (int i = 0; i < arrCoords.Length; i += 2)
            {
                points[cointer] = new Points();
                points[cointer].X = arrCoords[i];
                points[cointer].Y = arrCoords[i + 1];
                cointer++;
            }

            if (arrCoords.Length == 8)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (!WorkWithCoords.IsLinePerpendicular(points[i], points[i + 1], points[i + 1], points[i + 2]))
                    {
                        IsMetCondition = false;
                        break;
                    }
                }

                if (IsMetCondition)
                {
                    if (!WorkWithCoords.IsLinePerpendicular(points[2], points[3], points[3], points[0]))
                        IsMetCondition = false;

                    if (!WorkWithCoords.IsLinePerpendicular(points[3], points[0], points[0], points[1]))
                        IsMetCondition = false;

                    if (IsMetCondition)
                        return "Rectangle";
                }
                else
                    IsMetCondition = true;

    //            if (WorkWithCoords.ThisFigureNotHaveMathc(points))
    //            {
                    if ((WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]) && !WorkWithCoords.IsLineParallel(points[1], points[2], points[3], points[0])) || (!WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]) && WorkWithCoords.IsLineParallel(points[1], points[2], points[3], points[0])))
                        return "Trapeze";

                    if (WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]) && WorkWithCoords.IsLineParallel(points[1], points[2], points[3], points[0]))
                        return "Parallelogram";

                    return "Quadrangle";
     //           }
            }

            if (arrCoords.Length > 8) // && WorkWithCoords.ThisFigureNotHaveMathc(points)
                return "Polygonal";

            return "None";
        }

        public static double AveragePerimeterOfAllShapes(List<GeometryFigure.GeometryFigure> figures)
        {
            if (figures == null)
                throw new ArgumentNullException();

            return figures.Average(i => i.GetPerimeter());
        }

        public static double AverageAreaOfAllShapes(List<GeometryFigure.GeometryFigure> figures)
        {
            if (figures == null)
                throw new ArgumentNullException();

            return figures.Average(i => i.GetArea());
        }

        public static string FindFigureWithLargestArea(List<GeometryFigure.GeometryFigure> figures)
        {
            if (figures == null)
                throw new ArgumentNullException();

            GeometryFigure.GeometryFigure necessaryFigure = figures.Where(i => i.GetArea() == figures.Max(j => j.GetArea())).First();
            string result = null;
            result += "Type figure: " + necessaryFigure.TypeFigure + "; ";
            result += "Area: " + necessaryFigure.GetArea();
            return result;
        }

        public static string FindTypeFigureWithMaxAvaragePerimentr(List<GeometryFigure.GeometryFigure> figures)
        {
            if (figures == null)
                throw new ArgumentNullException();

            var figuresResult = figures.GroupBy(i => i.TypeFigure).Select(i => new { i.Key, Perimentr = i.Average(j => j.GetPerimeter())}).OrderByDescending(i => i.Perimentr).First(); 
            return (figuresResult.Key + " " + figuresResult.Perimentr).ToString();
        }
    }
}