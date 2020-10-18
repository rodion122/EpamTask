using InteractionWithGeometricFugire.BLL.GeometryFigure;

namespace InteractionWithGeometricFugire.BLL
{
    class CreateQuadrangle : ICreateGeometryFigure
    {
        public GeometryFigure.GeometryFigure FactoryMethod()
        {
            return new Quadrangle();
        }
    }
}