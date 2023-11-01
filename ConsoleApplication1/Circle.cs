using System;

namespace ConsoleApplication1 {
    public class Circle : IShape {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public Circle(Point center, Color color = Color.White, double radius = 1) {
            if (radius <= 0)
                throw new Exception("Радіус не може бути 0!");
            this.Center = center;
            Color = color;
        }

        public Color Color { get; set; }

        public void Move(int deltaX, int deltaY) {
            Center += new Point(deltaX, deltaY);
        }

        public void Scale(double scale) {
            if (scale == 0)
                throw new Exception("Не можна змінити розмір на 0!");
            Radius *= scale;
        }

        public void Rotate(double deltaRot) { }
    }
}