﻿namespace InteractionWithGeometricFugire.BLL.GeometryFigure
{
    class CreateRectangle : ICreateGeometryFigure
    {
        public GeometryFigure FactoryMethod()
        {
            return new Rectangle();
        }
    }
}