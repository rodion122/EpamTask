using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreateQuadrangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Quadrangle();
        }
    }
}