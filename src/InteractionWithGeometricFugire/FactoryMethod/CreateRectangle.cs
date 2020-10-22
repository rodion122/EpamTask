using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreateRectangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Rectangle();
        }
    }
}
