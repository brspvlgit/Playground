namespace Lesson19.Events;
class Button
{
    public event EventHandler? OnClickEvent;
    public string Name { get; set; } = "Start";

    public void Click ()
    {
        Console.WriteLine("Кнопка нажата");
        OnClickEvent?.Invoke(this, EventArgs.Empty);
    }
}
