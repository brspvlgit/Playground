﻿using Lesson19.Events.FileDownload;

namespace Lesson19.Events;
class Logger
{
    public void Log (string location)
    {
        Console.WriteLine($"[LOG]: Зафиксирована тревога в {location}");
    }

    public void Log (object? sender, DownloadEventArgs e)
    {
        Console.WriteLine($"[LOG] Файл загружен: {e.FileName}");
    }
}
