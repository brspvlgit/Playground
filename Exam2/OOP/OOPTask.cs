namespace Exam2;

public static class OOPTask
{
    public static void Do()
    {
        var repository = new Repository<UserModel>("Data/users.json").Load();
        
        repository.Add(new UserModel()
        {
            Id = 1,
            Name = "Pavel",
            Age = 29,
            Gender = "Male",
        });
        
        Console.WriteLine("Добавление элемента");
        
        repository.ReadAll();
        
        repository.Add(new UserModel()
        {
            Id = 2,
            Name = "Masha",
            Age = 15,
            Gender = "Female",
        });
        
        Console.WriteLine("Добавление элемента");
        
        repository.ReadAll();
        
        Console.WriteLine("Удаление элемента с id 2");
        
        repository.Delete(2);
        
        repository.ReadAll();
        
        Console.WriteLine("Изменение элемента с id 1");
        
        repository.Modify(1, new UserModel()
        {
            Name = "Pashka",
            Age = 28,
            Gender = "Male",
        });
        
        repository.ReadAll();
        
        
    }
}