namespace Lesson21;
internal class AsyncDemo
{
    private static readonly HttpClient _httpClient = new();

    public static async Task RunAsync ()
    {
        var demo = new AsyncDemo();

        using var cts = new CancellationTokenSource();
        var backgroundTask = demo.BackgroundCounterAsync(cts.Token);

        await demo.SimpleAsyncMethod();
        await demo.ParallelHttpRequestsAsync();
        await demo.ExceptionHandlingAsync();

        Console.WriteLine("\nНажмите любую клавишу, чтобы остановить фоновую задачу...");
        Console.ReadKey();

        cts.Cancel();
        await backgroundTask;

        Console.WriteLine("Фоновая задача остановлена. Программа завершена.");
    }

    public async Task SimpleAsyncMethod ()
    {
        Console.WriteLine("SimpleAsyncMethod started...");
        await Task.Delay(1000);
        Console.WriteLine("SimpleAsyncMethod finished.");
    }

    public async Task ParallelHttpRequestsAsync ()
    {
        Console.WriteLine("Starting parallel HTTP requests...");

        var urls = new[]
        {
            "https://api.adviceslip.com/advice",
            "https://icanhazdadjoke.com/"
        };

        var tasks = new Task<string>[urls.Length];

        for (int i = 0; i < urls.Length; i++)
        {
            tasks[i] = FetchUrlAsync(urls[i]);
        }

        string[] results = await Task.WhenAll(tasks);

        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"Response from {urls[i]}:\n{results[i].Substring(0, Math.Min(80, results[i].Length))}...\n");
        }
    }

    private async Task<string> FetchUrlAsync (string url)
    {
        if (url.Contains("icanhazdadjoke"))
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Accept", "application/json");
            var response = await _httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }

        return await _httpClient.GetStringAsync(url);
    }

    public async Task CancelableDelayAsync ()
    {
        using var cts = new CancellationTokenSource();

        Task delayTask = Task.Delay(5000, cts.Token);

        Console.WriteLine("Press any key to cancel delay...");
        Task keyTask = Task.Run(() => Console.ReadKey(true));

        Task finished = await Task.WhenAny(delayTask, keyTask);

        if (finished == keyTask)
        {
            cts.Cancel();
            Console.WriteLine("Delay cancelled by user.");
        }
        else
        {
            Console.WriteLine("Delay completed.");
        }

        try
        {
            await delayTask; // ждём, чтобы отловить TaskCanceledException, если отменено
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("TaskCanceledException caught as expected.");
        }
    }

    public async Task CpuBoundWorkAsync ()
    {
        Console.WriteLine("Starting work...");

        int result = await Task.Run(() =>
        {
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }

            return sum;
        });

        Console.WriteLine($"Result: {result}");
    }

    public async Task ExceptionHandlingAsync ()
    {
        try
        {
            Console.WriteLine("Starting ExceptionHandlingAsync...");
            await Task.Delay(500);

            throw new InvalidOperationException("Demo exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }

    public async Task BackgroundCounterAsync (CancellationToken token)
    {
        int counter = 0;

        try
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine($"[BackgroundCounter] Счётчик: {counter++}");
                await Task.Delay(1000, token);
            }
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("[BackgroundCounter] Задача отменена.");
        }
    }
}
