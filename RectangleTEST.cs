using System;
using Xunit;

namespace ConsoleApplication1 {
    public class Tests {
        private readonly Point _center = new Point(5, 5);

        [Theory]
        [InlineData(Color.White)]
        [InlineData(Color.Cyan)]
        [InlineData(Color.Green)]
        public void RectangleColor(Color color) {
            var rectangle = new Rectangle(_center, color: Color.Black);
            Assert.True(rectangle.Color == Color.Black);

            rectangle.Color = color;
            Assert.True(rectangle.Color == color);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(-2, 3)]
        public void RectangleMoveTest(int deltaX, int deltaY) {
            var rectangle = new Rectangle(_center);
            var initialPoints = rectangle.GetPoints();

            rectangle.Move(deltaX, deltaY);

            var finalPoints = rectangle.GetPoints();

            Assert.Equal(initialPoints.lowerLeft.X + deltaX, finalPoints.lowerLeft.X);
            Assert.Equal(initialPoints.lowerLeft.Y + deltaY, finalPoints.lowerLeft.Y);
            Assert.Equal(initialPoints.upperRight.X + deltaX, finalPoints.upperRight.X);
            Assert.Equal(initialPoints.upperRight.Y + deltaY, finalPoints.upperRight.Y);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(0)]
        public void RectangleScaleTest(uint scale) {
            var rectangle = new Rectangle(_center);
            var initialPoints = rectangle.GetPoints();

            if (scale == 0)
                Assert.Throws<Exception>(() => rectangle.Scale(scale));

            else {
                rectangle.Scale(scale);

                var finalPoints = rectangle.GetPoints();

                Assert.Equal(initialPoints.lowerLeft.X * scale, finalPoints.lowerLeft.X);
                Assert.Equal(initialPoints.lowerLeft.Y * scale, finalPoints.lowerLeft.Y);
                Assert.Equal(initialPoints.upperRight.X * scale, finalPoints.upperRight.X);
                Assert.Equal(initialPoints.upperRight.Y * scale, finalPoints.upperRight.Y);
            }
        }
    }
}