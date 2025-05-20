namespace Lesson21;

internal class Program
{
    static async Task Main ()
    {
        Console.WriteLine("Main started");

        Task task1 = Task.Run(() =>
        {
            Console.WriteLine("Task 1 started");
            Task.Delay(1000).Wait();
            Console.WriteLine("Task 1 completed");
        });

        Task task2 = task1.ContinueWith(t =>
        {
            Console.WriteLine("Task 2 started after Task 1");
            Task.Delay(1500).Wait();
            Console.WriteLine("Task 2 completed");
        });

        Task task3 = task2.ContinueWith(t =>
        {
            Console.WriteLine("Task 3 started after Task 2");
            Task.Delay(500).Wait();
            Console.WriteLine("Task 3 completed");
        });

        Task task4 = Task.Run(() =>
        {
            Console.WriteLine("Task 4 started");
            Task.Delay(7000).Wait();
            Console.WriteLine("Task 4 completed");
        });

        await Task.WhenAll(task3, task4);

        Console.WriteLine("Main completed");

        //await AsyncAlgorythm.RunAsync();
        //await AsyncDemo.RunAsync();
        await DataFetching.FetchDataAsync();
    }
}
