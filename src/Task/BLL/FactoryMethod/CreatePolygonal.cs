namespace Task.BLL.GeometryFigure
{
    class CreatePolygonal : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Polygonal();
        }
    }
}
