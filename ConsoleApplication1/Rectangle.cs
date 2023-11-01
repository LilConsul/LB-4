using System;

namespace ConsoleApplication1 {
    public class Rectangle : IShape {
        private Point uperLeft, upperRight, lowerLeft, lowerRight;
        private Point center;
        private double height, width;

        public double Height {
            get => height;
            set {
                if (value < 0)
                    throw new Exception("Висота не може бути менше 0!");
                height = value;
            }
        }

        public double Width {
            get => width;
            set {
                if (value < 0)
                    throw new Exception("Ширина не може бути менше 0!");
                width = value;
            }
        }

        public Color Color { get; set; }

        private void InitializePoint() {
            var x = height / 2;
            var y = width / 2;

            uperLeft = center - new Point(x, y);
            upperRight = center + new Point(-x, y);
            lowerLeft = center + new Point(x, -y);
            lowerRight = center + new Point(x, y);
        }

        public Rectangle(Point center, Color color = Color.White, double height = 1, double width = 1) {
            Color = color;
            Height = height;
            Width = width;
            this.center = center;
            InitializePoint();
        }

        public void Move(int deltaX, int deltaY) {
            center += new Point(deltaX, deltaY);
            InitializePoint();
        }

        public void Scale(double scale) {
            if (scale == 0)
                throw new Exception("Не можна змінити розмір на 0!");
            height *= scale;
            width *= scale;
            InitializePoint();
        }

        public void Rotate(double deltaRot) {
            uperLeft.Rotate(center, deltaRot);
            upperRight.Rotate(center, deltaRot);
            lowerLeft.Rotate(center, deltaRot);
            lowerRight.Rotate(center, deltaRot);
        }

        public (Point lowerLeft, Point upperRight) GetPoints() {
            return (lowerLeft, upperRight);
        }
    }
}