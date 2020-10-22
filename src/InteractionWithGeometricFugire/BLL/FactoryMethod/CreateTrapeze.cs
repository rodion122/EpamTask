using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreateTrapeze : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Trapeze();
        }
    }
}
