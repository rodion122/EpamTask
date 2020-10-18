using Task.BLL.Validation;

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
                bool IsMetCondition = true;

                for (int i = 0; i < arrCoords.Length; i += 2)
                {
                    points[cointer] = new Points();
                    points[cointer].X = arrCoords[i];
                    points[cointer].Y = arrCoords[i + 1];
                    cointer++;
                }


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

                    // square???
                    if (IsMetCondition)
                        return "Rectangle";
                }
                
                else
                    IsMetCondition = true;

                if( (WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]) && !WorkWithCoords.IsLineParallel(points[1], points[2], points[3], points[0]) ) || (!WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]) && WorkWithCoords.IsLineParallel(points[1], points[2], points[3], points[0])) )
                    return "Trapeze";


                if (WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]) && WorkWithCoords.IsLineParallel(points[1], points[2], points[3], points[0]))
                      return "Parallelogram";

                // нужна проверка на пересечение сторон 
                return "Quadrangle";
            }

            // нужна проверка на пересечение сторон
            if (arrCoords.Length > 8)
                return "Polygonal";

            return "None";
        }
    }
}
