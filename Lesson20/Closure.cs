namespace Lesson20;
public class Closure
{
    public static void Demo ()
    {
        var actions = new List<Action>();

        // Запоминаем действия, которые выводят значение i
        for (int i = 0; i < 3; i++)
        {
            actions.Add(() => Console.WriteLine($"i = {i}"));
        }

        // Выполняем действия
        foreach (var action in actions)
        {
            action();
        }
    }
}
