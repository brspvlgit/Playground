namespace Lesson21;
public class AsyncAlgorythm
{
    public static async Task RunAsync ()
    {
        Console.WriteLine("Старт программы");

        // Запускаем асинхронный метод и ждем его внутри Main через await,
        // но пока ждем, можем выполнять другую работу — смотри цикл ниже
        var downloadTask = GetDataAsync();

        // Пока GetDataAsync "ждет", здесь мы имитируем другую работу
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Делаю другую работу... {i + 1}");
            await Task.Delay(500);  // await не блокирует поток
        }

        // Ждем завершения асинхронного метода (если он ещё не завершился)
        string result = await downloadTask;

        Console.WriteLine($"Результат загрузки: {result}");
        Console.WriteLine("Программа завершена");
    }

    static async Task<string> GetDataAsync ()
    {
        Console.WriteLine("Начинаю загрузку данных...");
        await Task.Delay(3000);
        Console.WriteLine("Данные загружены");

        return "Данные успешно получены!";
    }
}
