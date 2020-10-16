using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL
{
    class Circle : GeometryFigure
    {
        // нужно реализовать
        //Circle()
        //{
        //}

        public Circle(double[] arrPoints, double radius)
        {
            this.arrPoints = new Points[0];
            this.arrPoints[0].X = arrPoints[0];
            this.arrPoints[0].Y = arrPoints[1];
            Radius = radius;
        }

        public double Radius { get; private set; }
        
        public override double GetArea() => Math.PI * Radius * Radius;

        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
