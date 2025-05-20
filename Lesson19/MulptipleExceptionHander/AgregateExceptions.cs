namespace Lesson19.MulptipleExceptionHander;
public class AgregateExceptions
{
    //Способ 1: Дождаться завершения работы всех задач, собирая исключения в Agregate
    public static void Run ()
    {
        try
        {
            Task.WhenAll(GetFaultyTasks()).Wait();
        }
        catch (AggregateException ex)
        {
            Console.WriteLine("Произошли исключения:");
            foreach (var inner in ex.InnerExceptions) //Проходимся по внутренним исключением агрегата
            {
                Console.WriteLine($"- {inner.GetType().Name}: {inner.Message}");
            }
        }
    }

    static List<Task> GetFaultyTasks ()
    {
        return new List<Task>
        {
            Task.Run(() => throw new InvalidOperationException("Некорректная операция")),
            Task.Run(() => throw new ArgumentNullException("Пустой аргумент")),
            Task.Run(() => throw new DivideByZeroException("Деление на ноль"))
        };
    }
}
