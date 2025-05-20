namespace Lesson20;
internal class Tasks
{
    public static async Task Demo ()
    {
        Console.WriteLine(" Task.Run с void-подобной задачей ");
        Task task1 = Task.Run(() => Console.WriteLine("Task 1 выполнена"));
        await task1;

        Console.WriteLine("\n Task<T> с возвращаемым значением ");
        Task<int> task2 = Task.Run(() =>
        {
            Thread.Sleep(500);
            return 42;
        });
        int result = await task2;
        Console.WriteLine($"Результат task2: {result}");

        Console.WriteLine("\n Обработка исключений ");
        try
        {
            await Task.Run(() =>
            {
                throw new InvalidOperationException("Что-то пошло не так в задаче");
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }

        Console.WriteLine("\n ContinueWith (продолжение задачи) ");
        Task task3 = Task.Run(() => Console.WriteLine("Начальная задача"))
            .ContinueWith(t => Console.WriteLine("Продолжение после task3"));

        await task3;

        Console.WriteLine("\n Task.WhenAll (несколько задач параллельно) ");
        var tasks = new List<Task<int>>
        {
            Task.Run(() => { Thread.Sleep(300); return 1; }),
            Task.Run(() => { Thread.Sleep(200); return 2; }),
            Task.Run(() => { Thread.Sleep(100); return 3; }),
        };

        int[] results = await Task.WhenAll(tasks);
        Console.WriteLine("Результаты: " + string.Join(", ", results));

        Console.WriteLine("\n Отмена задачи через CancellationToken ");
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task taskWithCancel = Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Задача отменена.");
                    return;
                }
                Console.WriteLine($"Работаю {i + 1}...");
                Thread.Sleep(300);
            }
        }, token);

        // Отменим через 600 мс
        await Task.Delay(600);
        cts.Cancel();

        try
        {
            await taskWithCancel;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Поймано исключение отмены.");
        }

        Console.WriteLine("\n Завершено ");
    }
}
