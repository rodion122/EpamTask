using InteractionWithGeometricFugire.DAL.GeometryFigures;

namespace InteractionWithGeometricFugire.BLL.FactoryMethod
{
    class CreatePolygonal : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Polygonal();
        }
    }
}
