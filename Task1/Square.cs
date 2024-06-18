namespace Task2
{
    internal class Square(double side) : Figure
    {
        public double Side { get; set; } = side;

        public override double GetSquare() => Side * Side;

        public override double GetPerimeter() => Side * 4;

        public override void PrintInfo()
            => Console.WriteLine($"Square\nSide:{Side}\nArea: {GetSquare()},\nPerimeter: {GetPerimeter}");
    }

}
