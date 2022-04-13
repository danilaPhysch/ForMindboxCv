using System;
using Library;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void IncorrectTriangleTest()
        {
            Assert.Throws<Exception>(() =>
            {
                Triangle triangle = new Triangle(100,2,1);
            });
        }

        [Test]
        public void IncorrectTriangleLineOneTest()
        {
            Assert.Throws<Exception>(() =>
            {
                Triangle triangle = new Triangle(0, 3, 4);
            });
        }

        [Test]
        public void CorrectTrianglePythagorasTest()
        {
            Assert.DoesNotThrow(() =>
            {
                Triangle triangle = new Triangle(5, 3, 4);
            });
        }

        [Test]
        public void CorrectTriangleTest()
        {
            Assert.DoesNotThrow(() =>
            {
                Triangle triangle = new Triangle(6, 3, 4);
            });
        }

        [Test]
        public void TrianglePythagorasCheckValueTest()
        {
            IFigure triangle = new Triangle(5, 3, 4);

            double actual = triangle.GetSquare();
            double expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleRandomCheckValueTest()
        {
            IFigure triangle = new Triangle(5, 3, 7);

            double actual = triangle.GetSquare();
            double expected = 6.495;

            Assert.AreEqual(expected, actual, 1E-3);
        }
    }
}