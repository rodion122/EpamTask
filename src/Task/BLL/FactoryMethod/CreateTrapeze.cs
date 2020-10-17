namespace Task.BLL.FactoryMethod
{
    class CreateTrapeze : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Trapeze();
        }
    }
}
