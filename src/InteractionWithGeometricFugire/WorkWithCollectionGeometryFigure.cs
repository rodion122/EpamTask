using System;
using System.Collections.Generic;
using InteractionWithGeometricFugire.FactoryMethod;
using InteractionWithGeometricFugire.Services;
using InteractionWithGeometricFugire.GeometryFigures;
using InteractionWithGeometricFugire.Validation;

namespace InteractionWithGeometricFugire
{
    public class WorkWithCollectionGeometryFigure
    {
        private string[] uploadedInformation;
        private List<GeometryFigure> figures = new List<GeometryFigure>();
        private GeometryFigure collectionItem;
        private ICreateGeometryFigure builderFigure;

        public WorkWithCollectionGeometryFigure()
        {
        }

        public void SetUploadedInformationFromFile(string route) => uploadedInformation = FileService.ReadInformation(route);

        public void CreateListFigures()
        {
            if (uploadedInformation == null)
                throw new ArgumentNullException();

            double[] informationAfterConvert;
            bool successfulCreateFigure = false;
            for (int i = 0; i < uploadedInformation.Length; i++)
            {
                successfulCreateFigure = false;
                if (ValidationFigure.TryParseData(uploadedInformation[i], out informationAfterConvert))
                {
                    switch (FigureService.DefineFigure(informationAfterConvert))
                    {
                        case "Circle":
                            if (!ValidationFigure.IsValidCircle(informationAfterConvert))
                                break;
                            builderFigure = new CreateCircle();
                            successfulCreateFigure = true;
                            break;

                        case "Triangle":
                            if (!ValidationFigure.IsValidTriangle(informationAfterConvert))
                                break;
                            builderFigure = new CreateTriangle();
                            successfulCreateFigure = true;
                            break;

                        case "Trapeze":
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

        public List<GeometryFigure> GetListFigures() => figures;
    }
}