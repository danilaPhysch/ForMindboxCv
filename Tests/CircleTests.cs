using System;
using Library;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class CircleTests
    {
        [Test]
        public void NegativeValueCircleTest()
        {
            Assert.Throws<Exception>(() =>
            {
                Circle circle = new Circle(-2);
            });
        }

        [Test]
        public void ZiroValueCircleTest()
        {
            Assert.Throws<Exception>(() =>
            {
                Circle circle = new Circle(0);
            });
        }

        [Test]
        public void PositiveValueCircleTest()
        {
            IFigure circle = new Circle(2);
            Assert.DoesNotThrow(() => circle.GetSquare());
        }

        [Test]
        public void CheckValueCircleTest()
        {
            IFigure circle = new Circle(5);

            double actual = circle.GetSquare();
            double expected = 25 * 2 * Math.PI;

            Assert.AreEqual(expected, actual);
        }
    }
}
