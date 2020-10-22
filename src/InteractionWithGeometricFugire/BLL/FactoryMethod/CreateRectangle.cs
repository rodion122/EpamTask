using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreateRectangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Rectangle();
        }
    }
}
