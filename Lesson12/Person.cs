namespace Lesson12;
public class Person
{
    // Константа
    private const int MaxAge = 120;
    private const int AdultAge = 18;

    // Приватная переменная (не связана со свойствами)
    private string _id;

    // Свойства
    public string FirstName { get; set; } //prop
    public string LastName { get; set; }

    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
                _age = 0;
            else if (value > MaxAge)
                _age = MaxAge;
            else
                _age = value;
        }
    }

    // Конструктор без параметров
    public Person () //ctor
    {
        _id = Guid.NewGuid().ToString();
        FirstName = "Неизвестно";
        LastName = "Неизвестно";
        Age = 0;
    }

    // Конструктор с параметрами
    public Person (string firstName, string lastName, int age)
    {
        _id = Guid.NewGuid().ToString();
        FirstName = firstName;
        LastName = lastName;
        Age = age; // Используем свойство, чтобы применить проверку
    }

    // Метод без параметров
    public void PrintInfo ()
    {
        Console.WriteLine($"ID: {_id}, Имя: {FirstName}, Фамилия: {LastName}, Возраст: {Age}");
    }

    // Метод с параметрами
    public void ChangeName (string newFirstName, string newLastName)
    {
        FirstName = newFirstName;
        LastName = newLastName;
    }

    // Метод с возвращаемым значением (проверка на совершеннолетие)
    public bool IsAdult ()
    {
        return Age >= AdultAge;
    }

    // Статический метод (сравнение двух объектов Person по возрасту)
    public static Person GetOlder (Person p1, Person p2)
    {
        return p1.Age >= p2.Age ? p1 : p2;
    }
}