using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreateTrapeze : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Trapeze();
        }
    }
}
