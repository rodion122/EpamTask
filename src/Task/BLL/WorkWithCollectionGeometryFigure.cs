using System;
using System.Collections.Generic;
using System.Linq;
using Task.DAL;

namespace Task.BLL.GeometryFigure
{
    class WorkWithCollectionGeometryFigure
    {
        private string[] uploadedInformation;
        private List<GeometryFigure> figures = new List<GeometryFigure>();
        private GeometryFigure forSetCoords;
        private FigureService helper = new FigureService();
        private ICreateGeometryFigure builderFigure;

        public WorkWithCollectionGeometryFigure()
        {
            forSetCoords = null;
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
            bool successfulCreateFigure = false;
            for (int i = 0; i < uploadedInformation.Length; i++)
            {
                successfulCreateFigure = false;
                if (Validation.TryParseData(uploadedInformation[i], out informationAfterConvert))
                {
                    switch (helper.DefineFigure(informationAfterConvert))
                    {
                        case "Circle":
                            if (!Validation.IsValidCircle(informationAfterConvert))
                                break;
                            builderFigure = new CreateCircle();
                            successfulCreateFigure = true;
                            break;

                        case "Triangle":
                            if (!Validation.IsValidTriangle(informationAfterConvert))
                                break;
                            builderFigure = new CreateTriangle();
                            successfulCreateFigure = true;
                            break;

                        case "Trapeze":
                            // ...

                            builderFigure = new CreateTrapeze();
                            successfulCreateFigure = true;
                            break;

                        case "Rectangle":
                            builderFigure = new CreateRectangle();
                            successfulCreateFigure = true;
                            break;

                        case "Quadrangle":
                            builderFigure = new CreateQuadrangle();
                            successfulCreateFigure = true;
                            break;

                        case "Polygonal":
                            builderFigure = new CreatePolygonal();
                            successfulCreateFigure = true;
                            break;

                        case "None":
                            break;
                    }

                    if(successfulCreateFigure)
                    {
                        forSetCoords = builderFigure.FactoryMethod();
                        forSetCoords.SerArrPoints(informationAfterConvert);
                        figures.Add(forSetCoords);
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

        // need fixed!!!
        public string FindTypeFigureWithMaxAvaragePerimentr()
        {
            if (figures == null)
                throw new ArgumentNullException();

            var figuresResult = figures.GroupBy(i => i.TypeFigure).Select(i => new { i.Key, Square = i.Average( j=> j.GetArea())});
            foreach (var item in figuresResult)
            {
                Console.WriteLine(item);
            }
            return null;
        }
    }
}