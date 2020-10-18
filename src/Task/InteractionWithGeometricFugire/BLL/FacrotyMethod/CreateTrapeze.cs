namespace InteractionWithGeometricFugire.BLL.GeometryFigure
{
    class CreateTrapeze : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Trapeze();
        }
    }
}
