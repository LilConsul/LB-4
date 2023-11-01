using System;

namespace ConsoleApplication1 {
    public class Point {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y) {
            X = x;
            Y = y;
        }

        public static Point operator -(Point p1, Point p2) {
            var newX = p1.X - p2.X;
            var newY = p1.Y - p2.Y;
            return new Point(newX, newY);
        }

        public static Point operator +(Point p1, Point p2) {
            var newX = p1.X + p2.X;
            var newY = p1.Y + p2.Y;
            return new Point(newX, newY);
        }

        public void Rotate(Point axisPoint, double angleInDegrees) {
            var angleInRadians = angleInDegrees * (Math.PI / 180.0);
            var cos = Math.Cos(angleInRadians);
            var sin = Math.Sin(angleInRadians);

            X = cos * (X - axisPoint.X) - sin * (Y - axisPoint.Y) + axisPoint.X;
            Y = sin * (X - axisPoint.X) + cos * (Y - axisPoint.Y) + axisPoint.Y;
        }
    }
}