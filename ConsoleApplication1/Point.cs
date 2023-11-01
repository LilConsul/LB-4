namespace LB_4 {
    public class Point {
        private double X { get; set; }
        private double Y { get; set; }

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
    }
}