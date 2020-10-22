using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreateQuadrangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Quadrangle();
        }
    }
}