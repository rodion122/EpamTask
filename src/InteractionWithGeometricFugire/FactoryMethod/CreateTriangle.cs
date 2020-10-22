using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreateTriangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Triangle();
        }
    }
}
