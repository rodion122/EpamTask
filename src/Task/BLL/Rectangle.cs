namespace Task.BLL
{
    class Rectangle : GeometricFigureWithSides
    {
        Rectangle()
        {
            figureSides = null;
        }

        public override double GetArea() => figureSides[0] * figureSides[1];
        
        protected override void setArrFigureSides()
        {
            figureSides = new double[4];
        }
    }
}
