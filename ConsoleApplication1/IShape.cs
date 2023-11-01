namespace LB_4 {
    interface IShape {
        void Rotate(int delRot);
        void Move(int delX, int delY);
        void Scale(uint scale);
        Color Color { get; set; }
    }
}