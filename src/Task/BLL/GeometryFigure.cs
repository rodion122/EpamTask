namespace Task.BLL
{
    abstract class GeometryFigure
    {
        protected Points[] arrPoints;

        public string TypeFigure { get; set; }

        abstract public double GetPerimeter();

        abstract public double GetArea();
    }
}