namespace Lesson19.Events.FileDownload;
class Notifier
{
    public void Notify (object? sender, DownloadEventArgs e)
    {
        Console.WriteLine($"Уведомление: файл {e.FileName} загружен.");
    }
}