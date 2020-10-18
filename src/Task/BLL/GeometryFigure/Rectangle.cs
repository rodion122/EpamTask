namespace Task.BLL.GeometryFigure
{
    class Rectangle : GeometricFigureWithSides
    {
        public Rectangle()
        {
            figureSides = null;
            TypeFigure = "Rectangle";
        }

        public override double GetArea() => figureSides[0] * figureSides[1];
    }
}
