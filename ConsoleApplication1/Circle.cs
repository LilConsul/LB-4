using System;

namespace ConsoleApplication1 {
    public class Circle : IShape {
        public Point center { get; set; }
        private double radius;

        public Circle(Point center, Color color = Color.White, double radius = 1) {
            if (radius <= 0)
                throw new Exception("Радіус не може бути 0!");
            this.center = center;
            Color = color;
        }

        public Color Color { get; set; }

        public void Move(int deltaX, int deltaY) {
            center += new Point(deltaX, deltaY);
        }

        public void Scale(double scale) {
            if (scale == 0)
                throw new Exception("Не можна змінити розмір на 0!");
            radius *= scale;
        }

        public void Rotate(double deltaRot) { }
        
        
    }
}