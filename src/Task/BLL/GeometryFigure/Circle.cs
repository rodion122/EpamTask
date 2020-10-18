using System;

namespace Task.BLL.GeometryFigure
{
    class Circle : GeometryFigure
    {
        private double radius;
        public Circle()
        {
            TypeFigure = "Circle";
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

        public override void SerArrPoints(double[] arrPoints)
        {
            this.arrPoints = new Points[1];
            this.arrPoints[0] = new Points();
            this.arrPoints[0].X = arrPoints[0];
            this.arrPoints[0].Y = arrPoints[1];
            radius = arrPoints[2];
        }
    }
}
