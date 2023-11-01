using ConsoleApplication1;
using Xunit;

namespace LB_4 {
    public class CircleTest {
        private readonly Point _center = new Point(5, 5);

        
        [Theory]
        [InlineData(Color.White)]
        [InlineData(Color.Cyan)]
        [InlineData(Color.Green)]
        public void CircleColor(Color color) {
            var rectangle = new Circle(_center, color: Color.Black);
            Assert.True(rectangle.Color == Color.Black);

            rectangle.Color = color;
            Assert.True(rectangle.Color == color);
        }
        
        [Theory]
        [InlineData(1, 2)]
        [InlineData(-2, 3)]
        public void CircleMove(int deltaX, int deltaY) {
            var actual = new Circle(_center);
            var expected = new Circle(_center);
            actual.Move(deltaX, deltaY);
            
            Assert.Equal(expected.Center.X + deltaX, actual.Center.X);
            Assert.Equal(expected.Center.Y + deltaY, actual.Center.Y);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(16)]
        public void CircleScale(double scale) {
            var actual = new Circle(_center);
            var expected = new Circle(_center);
            actual.Scale(scale);
            
            Assert.Equal(expected.Radius * scale, actual.Radius);
        }
        
    }
}