using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareComputingLibrary;

namespace SquareComputingfLibraryTests
{
    [TestClass]
    public class SquareComputing
    {
        [TestMethod]
        public void CircleGetSquareTest()
        {
            Circle circle = new Circle(2);
            double square = circle.GetSquare();

            Assert.AreEqual(square, 12.566370614359172);
        }

        [TestMethod]
        public void TriangleGetSquareTest()
        {
            Triangle triangle = new Triangle(2, 2, 3); 
            double square = triangle.GetSquare();

            Assert.AreEqual(square, 1.984313483298443);
        }
    }
}
