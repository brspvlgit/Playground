namespace Lesson19.Events.Alarm;
public class AlarmSystem
{
    public delegate void AlarmHandler (string location);
    public event AlarmHandler? OnAlarmEvent;

    public void Trigger (string location)
    {
        Console.WriteLine($"Тревога в {location}!");
        OnAlarmEvent?.Invoke(location);
    }
}
