using System;
using InteractionWithGeometricFugire.BLL;

namespace Task
{
    class Program
    {
        static void Main()
        {
            WorkWithCollectionGeometryFigure test = new WorkWithCollectionGeometryFigure();
            test.ReadInformationFromFile(@"D:\programms\Git\EpamTask\src\Task\FeguresCoords.txt");
            try
            {
                test.CreateListFigures();
            }catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (InteractionWithGeometricFugire.BLL.GeometryFigure.GeometryFigure item in test.GetListFigures())
                Console.WriteLine(item.TypeFigure + "  " + item.GetArea()  + "  " + item.GetPerimeter());

            try
            {
                Console.WriteLine("\n\n" + " Average area of all shapes: " + FigureService.AverageAreaOfAllShapes(test.GetListFigures()));
                Console.WriteLine(" Average perimeter of all shapes: " + FigureService.AveragePerimeterOfAllShapes(test.GetListFigures()));
                Console.WriteLine(" Figure with largest area: " + FigureService.FindFigureWithLargestArea(test.GetListFigures()));
                Console.WriteLine(" Type figure with max avarage perimentr: " + FigureService.FindTypeFigureWithMaxAvaragePerimentr(test.GetListFigures()));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Pause();
        }

        public static void Pause()
        {
            Console.WriteLine("\n\nPlease press any key...");
            Console.ReadKey();
        }
    }
}