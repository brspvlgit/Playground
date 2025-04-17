namespace Lesson_15.Struct;
readonly struct Vector
{
    public double X { get; }
    public double Y { get; }

    public Vector (double x, double y)
    {
        (X, Y) = (x, y);
    }

    public double Length => Math.Sqrt(X * X + Y * Y);
}
