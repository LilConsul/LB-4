using System;
using ConsoleApplication1;
using Xunit;

namespace LB_4 {
    public class RectangleTest {
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
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void RectangleScaleTest(double scale) {
            var actual = new Rectangle(_center);
            if (scale == 0) {
                Assert.Throws<Exception>(() => actual.Scale(scale));
                return;
            }

            actual.Scale(scale);
            actual.Scale(1 / scale);

            var expected = new Rectangle(_center);
            Assert.Equal(expected.GetPoints().lowerLeft.X, actual.GetPoints().lowerLeft.X);
            Assert.Equal(expected.GetPoints().lowerLeft.Y, actual.GetPoints().lowerLeft.Y);
            Assert.Equal(expected.GetPoints().upperRight.X, actual.GetPoints().upperRight.X);
            Assert.Equal(expected.GetPoints().upperRight.Y, actual.GetPoints().upperRight.Y);
        }

        [Theory]
        [InlineData(123)]
        [InlineData(32)]
        [InlineData(95)]
        [InlineData(23)]
        public void RectangleRotationTest(int rotate) {
            var actual = new Rectangle(_center);

            actual.Rotate(rotate);
            actual.Rotate(360 - rotate);

            var expected = new Rectangle(_center);

            Assert.Equal((int)expected.GetPoints().lowerLeft.X, (int)actual.GetPoints().lowerLeft.X);
            Assert.Equal((int)expected.GetPoints().lowerLeft.Y, (int)actual.GetPoints().lowerLeft.Y);
            Assert.Equal((int)expected.GetPoints().upperRight.X, (int)actual.GetPoints().upperRight.X);
            Assert.Equal((int)expected.GetPoints().upperRight.Y, (int)actual.GetPoints().upperRight.Y);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        public void RoundedRectangleTest(int rounded) {
            var ro = new RoundedRectangle(_center, roundness: rounded);
            Assert.Equal(ro.Roundness, rounded);
        }
    }
}