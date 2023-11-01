using System;

namespace ConsoleApplication1 {
    public class RoundedRectangle : Rectangle {
        private double _roundness;
        public double Roundness {
            get => _roundness;
            set {
                if (value < 0)
                    throw new Exception("Скруглення не може бути менше 0!");
                _roundness = value;
            }
        }

        public RoundedRectangle(
            Point center,
            Color color = Color.White,
            double height = 1,
            double width = 1,
            double roundness = 1)
            : base(center, color, height, width) {
            _roundness = roundness;
        }
    }
}