﻿
namespace Task.BLL.FactoryMethod
{
    class CreateRectangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Rectangle();
        }
    }
}