using System;
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
            for (int i = 0; i < test.GetListFigures().Count; i++)
                Console.WriteLine(test.GetListFigures()[i].TypeFigure + "  " + test.GetListFigures()[i].GetArea()  + "  " + test.GetListFigures()[i].GetPerimeter());
            
            FigureService.AverageAreaOfAllShapes(test.GetListFigures());
            FigureService.AveragePerimeterOfAllShapes(test.GetListFigures());
            FigureService.FindFigureWithLargestArea(test.GetListFigures());
            FigureService.FindTypeFigureWithMaxAvaragePerimentr(test.GetListFigures());
        }
    }
}