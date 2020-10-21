using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InteractionWithGeometricFugire.BLL.Tests
{
    [TestClass()]
    public class FigureServiceTests
    {
        [TestMethod()]
        public void DefineFigureQuadrangle()
        {
            // arrange
            string expects = "Quadrangle";
            double[] arrCoords = { 1, 3, 2, 1, 7, 2, 5, 4 };

            // act 
            string value = FigureService.DefineFigure(arrCoords);

            // assert
            Assert.AreEqual(expects, value);
        }

        [TestMethod()]
        public void DefineFigureTriangle()
        {
            // arrange
            string expects = "Triangle";
            double[] arrCoords = { 1, 3, 3, 3, 3, 1 };

            // act 
            string value = FigureService.DefineFigure(arrCoords);

            // assert
            Assert.AreEqual(expects, value);
        }

        [TestMethod()]
        public void DefineFigureCirlce()
        {
            // arrange
            string expects = "Circle";
            double[] arrCoords = { 1, 1, 4 };

            // act 
            string value = FigureService.DefineFigure(arrCoords);

            // assert
            Assert.AreEqual(expects, value);
        }

        [TestMethod()]
        public void DefineFigureParallelogram()
        {
            // arrange
            string expects = "Parallelogram";
            double[] arrCoords = { 1, 3, 6, 4, 7, 2, 2, 1 };

            // act 
            string value = FigureService.DefineFigure(arrCoords);

            // assert
            Assert.AreEqual(expects, value);
        }

        [TestMethod()]
        public void DefineFigurePolygonal()
        {
            // arrange
            string expects = "Polygonal";
            double[] arrCoords = { 1, 1, 2, 3, 6, 2, 6, 1, 5, 0 };

            // act 
            string value = FigureService.DefineFigure(arrCoords);

            // assert
            Assert.AreEqual(expects, value);
        }

        [TestMethod()]
        public void DefineFigureTrapeze()
        {
            // arrange
            string expects = "Trapeze";
            double[] arrCoords = { 1, 5, 3, 9, 11, 1, 5, 1 };

            // act 
            string value = FigureService.DefineFigure(arrCoords);

            // assert
            Assert.AreEqual(expects, value);
        }
    }
}