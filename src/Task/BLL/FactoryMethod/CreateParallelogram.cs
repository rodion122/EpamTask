namespace Task.BLL.GeometryFigure
{
    class CreateParallelogram : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Parallelogram();
        }
    }
}