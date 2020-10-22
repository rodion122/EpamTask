using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreateCircle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Circle();
        }
    }
}