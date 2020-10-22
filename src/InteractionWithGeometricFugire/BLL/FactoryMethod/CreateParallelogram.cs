using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreateParallelogram : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Parallelogram();
        }
    }
}