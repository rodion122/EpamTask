using Task.BLL.Validation;

namespace Task.BLL.GeometryFigure
{
    class Quadrangle : GeometricFigureWithSides
    {
        public Quadrangle()
        {
            TypeFigure = "Quadrangle";
            figureSides = null;
        }

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
        public override double GetArea()
        {
            return 0;
        }
    }
}
