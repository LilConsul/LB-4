using System;

namespace ConsoleApplication1 {
    public class RoundedRactangle : Ractangle {
        private double roundness;
        public double Roundness {
            get => roundness;
            set {
                if (value < 0)
                    throw new Exception("Скруглення не може бути менше 0!");
                roundness = value;
            }
        }

        public RoundedRactangle(
            Point center,
            Color color = Color.White,
            double height = 1,
            double width = 1,
            double roundness = 1)
            : base(center, color, height, width) {
            this.roundness = roundness;
        }
    }
}