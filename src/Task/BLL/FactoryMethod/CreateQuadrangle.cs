using Task.BLL.GeometryFigure;

namespace Task.BLL
{
    class CreateQuadrangle : ICreateGeometryFigure
    {
        public GeometryFigure.GeometryFigure FactoryMethod()
        {
            return new Quadrangle();
        }
    }
}