using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    interface ICreateGeometryFigure
    {
        GeometryFigure FactoryMethod();
    }
}
