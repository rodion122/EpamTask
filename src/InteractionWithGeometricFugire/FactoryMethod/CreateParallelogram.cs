using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreateParallelogram : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Parallelogram();
        }
    }
}