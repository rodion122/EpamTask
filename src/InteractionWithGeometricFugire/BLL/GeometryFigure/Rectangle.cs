namespace InteractionWithGeometricFugire.BLL.GeometryFigure
{
    class Rectangle : GeometricFigureWithSides
    {
        public Rectangle()
        {
            TypeFigure = "Rectangle";
        }

        public override double GetArea() => figureSides[0] * figureSides[1];
    }
}
