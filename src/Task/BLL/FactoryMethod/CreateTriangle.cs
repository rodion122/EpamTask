﻿namespace Task.BLL.GeometryFigure
{
    class CreateTriangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Triangle();
        }
    }
}
