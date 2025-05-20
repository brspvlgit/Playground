namespace Lesson20;
internal class Threads
{
    private static int workerThreads;
    private static int completionPortThreads;

    public static void Demo ()
    {
        Console.WriteLine("Main thread started");

        // 1. Создание потока с методом без параметров
        Thread thread1 = new Thread(SimpleMethod);
        thread1.Name = "Worker 1";
        thread1.Priority = ThreadPriority.Normal;

        // 2. Создание потока с методом, принимающим параметр
        Thread thread2 = new Thread(MethodWithParameter);
        thread2.Name = "Worker 2";
        thread2.Priority = ThreadPriority.AboveNormal;

        // 3. Создание потока с лямбда-выражением
        Thread thread3 = new Thread(() =>
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} started");
            Thread.Sleep(500);
            Console.WriteLine($"{Thread.CurrentThread.Name} finished");
        });
        thread3.Name = "Lambda Thread";

        // Запуск потоков
        thread1.Start();
        thread2.Start("Hello from parameter");
        thread3.Start();

        // Проверка активности потока
        Console.WriteLine($"Is {thread1.Name} alive? {thread1.IsAlive}");

        // Ожидание завершения потоков
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("All threads finished");

        // 4. Пример прерывания потока
        Thread interruptibleThread = new Thread(InterruptibleMethod);
        interruptibleThread.Name = "Interruptible Thread";
        interruptibleThread.Start();

        Thread.Sleep(1000);
        Console.WriteLine("Sending interrupt...");
        interruptibleThread.Interrupt(); // генерирует исключение в потоке

        interruptibleThread.Join();

        Console.WriteLine("Main thread finished");

        //5. Получаем максимальное количество потоков
        ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
        Console.WriteLine($"Максимум рабочих потоков: {workerThreads}");
        Console.WriteLine($"Максимум потоков ввода-вывода: {completionPortThreads}");
    }

    private static void SimpleMethod ()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} started");
        Thread.Sleep(1000);
        Console.WriteLine($"{Thread.CurrentThread.Name} finished");
    }

    private static void MethodWithParameter (object? message)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} received message: {message}");
        Thread.Sleep(800);
        Console.WriteLine($"{Thread.CurrentThread.Name} finished");
    }

    private static void InterruptibleMethod ()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} waiting...");
        try
        {
            Thread.Sleep(5000); // Будет прерван
            Console.WriteLine("This line will probably not run");
        }
        catch (ThreadInterruptedException)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} was interrupted!");
        }
    }
}
