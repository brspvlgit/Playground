namespace Lesson21;
public class DataFetching
{
    public static async Task FetchDataAsync ()
    {
        var cts = new CancellationTokenSource();

        var spinnerTask = ShowSpinnerAsync(cts.Token);

        var task1 = GetDataFromSourceAsync("База данных");
        var task2 = GetDataFromSourceAsync("API");
        var task3 = GetDataFromSourceAsync("Текстовый файл");

        string[] results = await Task.WhenAll(task1, task2, task3);
        cts.Cancel();
        await spinnerTask;

        Console.WriteLine("\nРезультаты:");

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    static async Task<string> GetDataFromSourceAsync (string sourceName)
    {
        var rand = new Random();
        int delay = rand.Next(1000, 5000);
        await Task.Delay(delay);

        return $"{sourceName} ответил за {delay} мс";
    }

    static async Task ShowSpinnerAsync (CancellationToken token)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int i = 0;

        while (!token.IsCancellationRequested)
        {
            Console.Write($"\rЗагрузка...{spinner[i++ % spinner.Length]}");

            try
            {
                await Task.Delay(200, token);
            }
            catch (TaskCanceledException)
            {
                break;
            }
        }
    }
}
