namespace Task.BLL
{
    class CreateCircle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Circle();
        }
    }
}
