using Task.BLL;
using Task.BLL.GeometryFigure;

namespace Task
{
    class Program
    {
        static void Main()
        {
            WorkWithCollectionGeometryFigure test = new WorkWithCollectionGeometryFigure();
            test.ReadInformationFromFile(@"D:\programms\Git\EpamTask\src\Task\FeguresCoords.txt");
            test.CreateListFigures();
            FigureService.AverageAreaOfAllShapes(test.GetListFigures());
            FigureService.AveragePerimeterOfAllShapes(test.GetListFigures());
            FigureService.FindFigureWithLargestArea(test.GetListFigures());
            // надо исправить! 
            FigureService.FindTypeFigureWithMaxAvaragePerimentr(test.GetListFigures());
        }
    }
}