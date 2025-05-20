namespace Lesson20;
public class ThreadsSync
{
    private static int _sharedCounter = 0;

    private static object _lockObject = new object();
    private static object _monitorObject = new object();
    private static Mutex _mutex = new Mutex();
    private static Semaphore _semaphore = new Semaphore(2, 2); // Разрешено максимум 2 потока одновременно

    public static void Demo ()
    {
        Console.WriteLine("Пример с lock");
        RunWithLock();

        Console.WriteLine("\nПример с Monitor");
        RunWithMonitor();

        Console.WriteLine("\nПример с Mutex");
        RunWithMutex();

        Console.WriteLine("\nПример с Semaphore");
        RunWithSemaphore();
    }

    private static void RunWithLock ()
    {
        _sharedCounter = 0;
        Thread[] threads = new Thread[5];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    lock (_lockObject)
                    {
                        _sharedCounter++;
                    }
                }
            });

            threads[i].Start();
        }

        foreach (var t in threads) t.Join();

        Console.WriteLine($"Результат (lock): {_sharedCounter}");
    }

    private static void RunWithMonitor ()
    {
        _sharedCounter = 0;
        Thread[] threads = new Thread[5];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_monitorObject, ref lockTaken);
                        _sharedCounter++;
                    }
                    finally
                    {
                        if (lockTaken) Monitor.Exit(_monitorObject);
                    }
                }
            });

            threads[i].Start();
        }

        foreach (var t in threads) t.Join();

        Console.WriteLine($"Результат (Monitor): {_sharedCounter}");
    }

    private static void RunWithMutex ()
    {
        _sharedCounter = 0;
        Thread[] threads = new Thread[5];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    _mutex.WaitOne(); // захват
                    _sharedCounter++;
                    _mutex.ReleaseMutex(); // освобождение
                }
            });

            threads[i].Start();
        }

        foreach (var t in threads) t.Join();

        Console.WriteLine($"Результат (Mutex): {_sharedCounter}");
    }

    private static void RunWithSemaphore ()
    {
        _sharedCounter = 0;
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    _semaphore.WaitOne(); // пробуем войти
                    _sharedCounter++;
                    _semaphore.Release(); // освобождаем
                }
            });

            threads[i].Start();
        }

        foreach (var t in threads) t.Join();

        Console.WriteLine($"Результат (Semaphore, одновременно макс. 2 потока): {_sharedCounter}");
    }
}
