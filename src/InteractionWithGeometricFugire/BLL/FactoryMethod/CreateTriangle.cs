using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreateTriangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Triangle();
        }
    }
}
