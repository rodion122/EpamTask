namespace Task.BLL
{
    class CreateTriangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Triangle();
        }
    }
}
