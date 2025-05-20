namespace Lesson19.MulptipleExceptionHander;
public class ListExceptions
{
    //Способ 2: В качестве обработки исключений добавлять их к списку, и выводить в нужный момент.
    static void Demo ()
    {
        var exceptions = new List<Exception>();

        try
        {
            ThrowOne();
        }
        catch (Exception ex)
        {
            exceptions.Add(ex);
        }

        try
        {
            ThrowTwo();
        }
        catch (Exception ex)
        {
            exceptions.Add(ex);
        }

        try
        {
            ThrowThree();
        }
        catch (Exception ex)
        {
            exceptions.Add(ex);
        }

        Console.WriteLine("Собрано исключений: " + exceptions.Count);

        foreach (var ex in exceptions)
        {
            Console.WriteLine($"- {ex.GetType().Name}: {ex.Message}");
        }
    }

    static void ThrowOne () => throw new InvalidOperationException("Неверная операция");
    static void ThrowTwo () => throw new ArgumentException("Ошибка в аргументе");
    static void ThrowThree () => throw new FormatException("Ошибка в формате");
}
