using Lesson15.Nested;

namespace Lesson18.Record;
public static class RecordHelper
{
    public record Person (string Name, int Age);
    public record Human (string Name, int Age)
    {
        public string Address { get; init; } // Можно задать только при инициализации
    }

    public readonly record struct Coordinates (int X, int Y);

    public static void PersonRun ()
    {
        var person1 = new Person("Jane", 30);
        var person2 = new Person("Jane", 30);
        var person3 = new Person("John", 25);
        var htmlBuilder = new HtmlBuilder("div");

        Console.WriteLine(person1); // Person { Name = Jane, Age = 30 }
        Console.WriteLine(htmlBuilder);

        // Сравнение по значению
        Console.WriteLine(person1 == person2); // True, потому что значение одинаковое
        Console.WriteLine(person1 == person3); // False, потому что значения разные

        var alice = new Person("Alice", 30);
        var sameOldAlice = alice with { Age = 31 }; // Копия с изменённым Age
        Console.WriteLine(alice); // Person { Name = Alice, Age = 30 }
        Console.WriteLine(sameOldAlice); // Person { Name = Alice, Age = 31 }

        var hooman = new Human("Alice", 30) { Address = "123 Main St" };
        var (name, age) = hooman; //конструкция в скобках = кортеж (tuple)
        Console.WriteLine(hooman); // Person { Name = Alice, Age = 30, Address = 123 Main St }
        Console.WriteLine($"Name: {name}, Age: {age}"); // Name: Alice, Age: 30
    }

    public static void CoordinatesRun ()
    {
        var point1 = new Coordinates(5, 10);
        var point2 = new Coordinates(5, 10);
        var point3 = new Coordinates(10, 20);

        Console.WriteLine(point1); // Point { X = 5, Y = 10 }

        // Сравнение по значению
        Console.WriteLine(point1 == point2); // True, потому что значения одинаковые
        Console.WriteLine(point1 == point3); // False, потому что значения разные

        var point4 = new Coordinates(5, 10);
        Coordinates point5 = point4; // Копирование значений

        point5 = new Coordinates(10, 20); // Изменение копии

        Console.WriteLine(point4); // Point { X = 5, Y = 10 }
        Console.WriteLine(point5); // Point { X = 10, Y = 20 }
    }
}
