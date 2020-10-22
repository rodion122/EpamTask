using InteractionWithGeometricFugire.GeometryFigures;

namespace InteractionWithGeometricFugire.FactoryMethod
{
    class CreatePolygonal : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Polygonal();
        }
    }
}
