using System;

namespace Task.BLL
{
    class Circle : GeometryFigure
    {
        private double radius;
        public Circle()
        {
        }
        
        public double Radius 
        {
            get => radius;
            set
            {
                if (value > 0)
                    radius = value;
            }
        }
        
        public override double GetArea() => Math.PI * Radius * Radius;

        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
