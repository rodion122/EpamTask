using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL;
using Task.BLL.FactoryMethod;

namespace Task.BLL
{
    class WorkWithCollectionGeometryFigure
    {
        private string[] uploadedInformation;
        private List<GeometryFigure> figures = new List<GeometryFigure>();
        private FigureService helper = new FigureService();
        private ICreateGeometryFigure builderFigure;

        public WorkWithCollectionGeometryFigure()
        {
            uploadedInformation = null;
            builderFigure = null;
        }

        public void ReadInformationInFile(string route)
        {
             uploadedInformation = FileManager.ReadInformation(route);
        }

        public void CreateListFigures()
        {
            if (uploadedInformation == null)
                throw new ArgumentNullException();

            double[] informationAfterConvert;
            for (int i = 0; i < uploadedInformation.Length; i++)
            {
                if(Validation.TryParseData(uploadedInformation[i], out informationAfterConvert))
                {
                    switch (helper.DefineFigure(informationAfterConvert))
                    {
                        case "Circle":
                            // валидация фигуры по точкам
                            // ...
                            
                            builderFigure = new CreateCircle();
                            figures.Add(builderFigure.FactoryMethod());
                            break;

                        case "Triangle":
                            // ..

                            builderFigure = new CreateTriangle();
                            figures.Add(builderFigure.FactoryMethod());
                            break;

                        case "Trapeze":
                            // ...

                            builderFigure = new CreateTrapeze();
                            figures.Add(builderFigure.FactoryMethod());
                            break;

                        case "Rectangle":
                            // ...

                            builderFigure = new CreateRectangle();
                            figures.Add(builderFigure.FactoryMethod());
                            break;

                        case "Quadrangle":
                            break;

                        case "None":
                            break;
                    }
                }
            }
        }

        public double AveragePerimeterOfAllShapes()
        {
            if (figures == null)
                throw new ArgumentNullException();

            return figures.Average(i => i.GetPerimeter());
        }

        public double AverageAreaOfAllShapes()
        {
            if (figures == null)
                throw new ArgumentNullException();

            return figures.Average(i => i.GetArea());
        }

        public string FindFigureWithLargestArea()
        {
            if (figures == null)
                throw new ArgumentNullException();

            IEnumerable<GeometryFigure> necessaryFigure = figures.Where(i => i.GetArea() == figures.Max(j => j.GetArea()));
            string result = null;
            foreach (var item in necessaryFigure)
            {
                result += "Type figure: " + item.TypeFigure + ";";
                result += "Area: " + item.GetArea() + "\n\n";
            }
            return result;
        }

        //public string FindTypeFigureWithMaxAvaragePerimentr()
        //{
        //    if (figures == null)
        //        throw new ArgumentNullException();

        //    IEnumerable<IGrouping<string, Task.BLL.GeometryFigure> figure = figures.GroupBy(i => i.TypeFigure).Select(i => i.Average(j=>j.GetArea()));
        //}
    }
}
