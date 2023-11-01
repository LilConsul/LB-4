namespace ConsoleApplication1 {
    interface IShape {
        void Rotate(double deltaRot);
        void Move(int deltaX, int deltaY);
        void Scale(double scale);
        Color Color { get; set; }
    }
}