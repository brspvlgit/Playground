using System.Diagnostics;

namespace Lesson20;
internal class Parallels
{
    public static void RunAll ()
    {
        Console.WriteLine(" Parallel.For ");

        Parallel.For(0, 5, i =>
        {
            Console.WriteLine($"Итерация {i}, поток {Environment.CurrentManagedThreadId}");
            Thread.Sleep(200);
        });

        Console.WriteLine("\n Parallel.ForEach ");
        var items = new List<string> { "яблоко", "банан", "вишня", "груша" };

        Parallel.ForEach(items, item =>
        {
            Console.WriteLine($"Обработка: {item}, поток {Environment.CurrentManagedThreadId}");
            Thread.Sleep(150);
        });

        Console.WriteLine("\n Parallel.Invoke ");
        Parallel.Invoke(
            () => Console.WriteLine("Задача 1 выполняется"),
            () => Console.WriteLine("Задача 2 выполняется"),
            () => Console.WriteLine("Задача 3 выполняется")
        );

        Console.WriteLine("\n Break и Stop в Parallel.For ");

        Parallel.For(0, 10, (i, state) =>
        {
            Console.WriteLine($"Итерация {i}");

            if (i == 4)
            {
                Console.WriteLine("Вызов state.Break()");
                state.Break(); // завершит только последующие итерации с большим индексом
            }

            Thread.Sleep(100);
        });

        Console.WriteLine("\n Сравнение времени обычного цикла и Parallel.For ");
        var stopwatch = new Stopwatch();

        stopwatch.Start();

        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(100);
        }
        stopwatch.Stop();

        Console.WriteLine($"Обычный цикл: {stopwatch.ElapsedMilliseconds} мс");

        stopwatch.Restart();

        Parallel.For(0, 10, i =>
        {
            Thread.Sleep(100);
        });

        stopwatch.Stop();
        Console.WriteLine($"Parallel.For: {stopwatch.ElapsedMilliseconds} мс");

        Console.WriteLine("\n Работа с общим ресурсом ");
        int sum = 0;
        object lockObj = new object();

        Parallel.For(0, 1000, i =>
        {
            lock (lockObj)
            {
                sum += i;
            }
        });

        Console.WriteLine($"Сумма чисел от 0 до 999: {sum}");
    }
}
