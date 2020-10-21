namespace InteractionWithGeometricFugire.BLL.GeometryFigure
{
    class CreateTriangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Triangle();
        }
    }
}
