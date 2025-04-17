namespace Lesson_15.Struct;
struct Point
{
    public int X;
    public int Y;

    public void Move (int dx, int dy)
    {
        X += dx;
        Y += dy;
    }
}

class StructHelper
{
    public static void PointRun ()
    {
        Point a = new Point { X = 1, Y = 2 };
        Point b = a; // копия!

        b.Move(10, 10);

        Console.WriteLine($"a: {a.X}, {a.Y}"); // 1, 2
        Console.WriteLine($"b: {b.X}, {b.Y}"); // 11, 12

        //Если бы это был класс — обе переменные a и b ссылались бы на один и тот же объект.

        Point p = new Point { X = 0, Y = 0 };

        p.Move(5, 5);

        Console.WriteLine($"{p.X}, {p.Y}"); // Всё ещё 0, 0
        //Point — это структура, и при передаче в метод происходит копирование.
    }
}