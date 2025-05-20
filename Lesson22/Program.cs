using Lesson22.Models;

namespace Lesson22;

internal class Program
{
    static async Task Main (string[] args)
    {
        string baseDir = AppContext.BaseDirectory;
        //string baseDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
        string newFolderPath = Path.Combine(baseDir, "ProjectFiles");

        DirectoryService.EnsureExists(newFolderPath);
        string filePath = Path.Combine(newFolderPath, "example.txt");

        FileService.Create(filePath, "Привет! Это содержимое файла.");

        string content = FileService.Read(filePath);
        Console.WriteLine("Содержимое файла:");
        Console.WriteLine(content);

        DirectoryService.PrintInfo(newFolderPath);
        DirectoryService.PrintPathInfo(newFolderPath, "example.txt");
    }

    public static async Task FileParser ()
    {
        var users = new List<User>
        {
            new User { Id = 1, Name = "Alice Smith", Username = "alice", Email = "alice@example.com" },
            new User { Id = 2, Name = "Bob Johnson", Username = "bobby", Email = "bob@example.com" }
        };
    }

    private static User AddUser ()
    {
        Console.WriteLine("\nДобавьте нового пользователя.");
        Console.Write("Id: ");
        int newId = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Name: ");
        string newName = Console.ReadLine() ?? "";

        Console.Write("Username: ");
        string newUsername = Console.ReadLine() ?? "";

        Console.Write("Email: ");
        string newEmail = Console.ReadLine() ?? "";

        return new User
        {
            Id = newId,
            Name = newName,
            Username = newUsername,
            Email = newEmail
        };
    }

    private static void PrintUsers (IEnumerable<User>? users)
    {
        if (users == null)
        {
            Console.WriteLine("Нет данных");
            return;
        }
        foreach (var u in users)
        {
            Console.WriteLine($"Id={u.Id}, " +
                $"Name={u.Name}, " +
                $"Username={u.Username}, " +
                $"Email={u.Email}");
        }
    }
}
