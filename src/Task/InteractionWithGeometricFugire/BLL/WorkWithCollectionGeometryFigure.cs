using System;
using System.Collections.Generic;
using InteractionWithGeometricFugire.DAL;
using InteractionWithGeometricFugire.BLL.GeometryFigure;

namespace InteractionWithGeometricFugire.BLL
{
    public class WorkWithCollectionGeometryFigure
    {
        private string[] uploadedInformation;
        private List<GeometryFigure.GeometryFigure> figures = new List<GeometryFigure.GeometryFigure>();
        private GeometryFigure.GeometryFigure collectionItem;
        private ICreateGeometryFigure builderFigure;

        public WorkWithCollectionGeometryFigure()
        {
            collectionItem = null;
            uploadedInformation = null;
            builderFigure = null;
        }

        public void ReadInformationFromFile(string route)
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
                    switch (FigureService.DefineFigure(informationAfterConvert))
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

                        case "Parallelogram":
                            builderFigure = new CreateParallelogram();
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
                        collectionItem = builderFigure.FactoryMethod();
                        collectionItem.SerArrPoints(informationAfterConvert);
                        figures.Add(collectionItem);
                    }
                }
            }
        }

        public List<GeometryFigure.GeometryFigure> GetListFigures() => figures;
    }
}