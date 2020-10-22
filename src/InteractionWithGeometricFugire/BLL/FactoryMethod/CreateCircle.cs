using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreateCircle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Circle();
        }
    }
}