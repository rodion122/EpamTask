namespace InteractionWithGeometricFugire.GeometryFigures
{
    public abstract class GeometryFigure
    {
        protected Points[] arrPoints;

        abstract public void SerArrPoints(double[] arrPoints);

        public string TypeFigure { get; set; }

        abstract public double GetPerimeter();

        abstract public double GetArea();
    }
}