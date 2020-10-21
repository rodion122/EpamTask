using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            points[0] = new Points() { X = 2, Y = 1 };
            points[1] = new Points() { X = 1, Y = 2 };
            points[2] = new Points() { X = 5, Y = 4 };
            points[3] = new Points() { X = 4, Y = 5 };

            // act 
            bool result = WorkWithCoords.IsLinesParallel(points[0], points[1], points[2], points[3]);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsFigureOneLine()
        {
            // arrange
            Points[] points = new Points[4];
            points[0] = new Points() { X = 1, Y = 2 };
            points[1] = new Points() { X = 3, Y = 2 };
            points[2] = new Points() { X = 5, Y = 2 };
            points[3] = new Points() { X = 6, Y = 2 };
            
            // act 
            bool result = WorkWithCoords.IsLinesParallel(points[0], points[1], points[2], points[3]);

            // assert
            Assert.IsTrue(result);
        }
    }
}