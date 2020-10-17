namespace Task.BLL.GeometryFigure
{
    class CreateCircle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Circle();
        }
    }
}