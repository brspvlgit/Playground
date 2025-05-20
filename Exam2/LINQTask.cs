namespace Exam2;

public static class LINQTask
{
    public static void Do()
    {
        var elements = new List<int>() { 8, 1, 4, 2, 5, 2, 0 };
        
        Console.WriteLine("Исходная коллекция:");
        elements.ForEach(x => Console.Write($"{x} "));
        Console.Write("\n");
        
        var sorted = elements.Order().ToList();
        
        Console.WriteLine("Отсортированные элементы:");
        sorted.ForEach(x => Console.Write($"{x} "));
        Console.Write("\n");
        
        Console.WriteLine("Результат:");
        var half = (int)Math.Ceiling((decimal)elements.Count / 2);
        sorted
            .TakeLast(half)
            .Select(x => x * x)
            .ToList()
            .ForEach(x => Console.Write($"{x} "));
    }
}