using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteractionWithGeometricFugire.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionWithGeometricFugire.BLL.Tests
{
    [TestClass()]
    public class WorkWithCoordsTests
    {
        [TestMethod()]
        public void IsLineParallelTest()
        {
            // arrange
            Points[] points = new Points[4];
            for (int i = 0; i < 4; i++)
                points[i] = new Points();
            points[0].X = 2;
            points[0].Y = 1;
            points[1].X = 1;
            points[1].Y = 2;
            points[2].X = 5;
            points[2].Y = 4;
            points[3].X = 4;
            points[3].Y = 5;

            // act 
            bool result = WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsFigureOneLine()
        {
            // arrange
            Points[] points = new Points[4];
            for (int i = 0; i < 4; i++)
                points[i] = new Points();
            points[0].X = 1;
            points[0].Y = 2;
            points[1].X = 3;
            points[1].Y = 2;
            points[2].X = 5;
            points[2].Y = 2;
            points[3].X = 6;
            points[3].Y = 2;

            // act 
            bool result = WorkWithCoords.IsLineParallel(points[0], points[1], points[2], points[3]);

            // assert
            Assert.IsTrue(result);
        }
    }
}