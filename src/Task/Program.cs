using Task.BLL;

namespace Task
{
    class Program
    {
        static void Main()
        {
            WorkWithCollectionGeometryFigure test = new WorkWithCollectionGeometryFigure();
            test.ReadInformationInFile(@"D:\programms\Git\EpamTask\src\Task\FeguresCoords.txt");
            test.CreateListFigures();
            test.AverageAreaOfAllShapes();
            test.AveragePerimeterOfAllShapes();
            test.FindFigureWithLargestArea();
            test.FindTypeFigureWithMaxAvaragePerimentr();
        }
    }
}
