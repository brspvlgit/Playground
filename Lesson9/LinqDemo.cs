namespace Lesson9;

class LinqDemo
{
    public static void Show ()
    {
        // Создание тестового списка объектов для демонстрации
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 },
            new Person { Name = "David", Age = 40 },
            new Person { Name = "Eva", Age = 22 }
        };

        // 1. Операция Where (фильтрация)
        // Методный синтаксис
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers (method syntax):");
        foreach (var num in evenNumbersMethod)
            Console.WriteLine(num);

        // Запросный синтаксис
        var evenNumbersQuery = from n in numbers
                               where n % 2 == 0
                               select n;
        Console.WriteLine("\nEven numbers (query syntax):");
        foreach (var num in evenNumbersQuery)
            Console.WriteLine(num);

        Console.WriteLine();

        // 2. Операция Select (проекция)
        // Методный синтаксис
        var namesMethod = people.Select(p => p.Name);
        Console.WriteLine("Names (method syntax):");
        foreach (var name in namesMethod)
            Console.WriteLine(name);

        // Запросный синтаксис
        var namesQuery = from p in people
                         select p.Name;
        Console.WriteLine("\nNames (query syntax):");
        foreach (var name in namesQuery)
            Console.WriteLine(name);

        Console.WriteLine();

        // 3. Операция OrderBy (сортировка)
        // Методный синтаксис
        var sortedByAgeMethod = people.OrderBy(p => p.Age);
        Console.WriteLine("People sorted by age (method syntax):");
        foreach (var person in sortedByAgeMethod)
            Console.WriteLine($"{person.Name}: {person.Age}");

        // Запросный синтаксис
        var sortedByAgeQuery = from p in people
                               orderby p.Age
                               select p;
        Console.WriteLine("\nPeople sorted by age (query syntax):");
        foreach (var person in sortedByAgeQuery)
            Console.WriteLine($"{person.Name}: {person.Age}");

        Console.WriteLine();

        // 4. Операция GroupBy (группировка)
        // Методный синтаксис
        var groupedByAgeMethod = people.GroupBy(p => p.Age);
        Console.WriteLine("People grouped by age (method syntax):");
        foreach (var group in groupedByAgeMethod)
        {
            Console.WriteLine($"Age: {group.Key}");
            foreach (var person in group)
                Console.WriteLine($"  {person.Name}");
        }

        // Запросный синтаксис
        var groupedByAgeQuery = from p in people
                                group p by p.Age into ageGroup
                                select ageGroup;
        Console.WriteLine("\nPeople grouped by age (query syntax):");
        foreach (var group in groupedByAgeQuery)
        {
            Console.WriteLine($"Age: {group.Key}");
            foreach (var person in group)
                Console.WriteLine($"  {person.Name}");
        }

        Console.WriteLine();

        // 5. Операция Join (соединение коллекций)
        // Методный синтаксис
        var joined = people.Join(
            new List<Department>
            {
                new Department { PersonName = "Alice", DepartmentName = "HR" },
                new Department { PersonName = "Bob", DepartmentName = "IT" },
                new Department { PersonName = "Charlie", DepartmentName = "Finance" }
            },
            person => person.Name,
            department => department.PersonName,
            (person, department) => new { person.Name, department.DepartmentName }
        );
        Console.WriteLine("People and their departments (method syntax):");
        foreach (var item in joined)
            Console.WriteLine($"{item.Name} works in {item.DepartmentName}");

        // Запросный синтаксис
        var joinedQuery = from p in people
                          join d in new List<Department>
                          {
                              new Department { PersonName = "Alice", DepartmentName = "HR" },
                              new Department { PersonName = "Bob", DepartmentName = "IT" },
                              new Department { PersonName = "Charlie", DepartmentName = "Finance" }
                          } on p.Name equals d.PersonName
                          select new { p.Name, d.DepartmentName };

        Console.WriteLine("\nPeople and their departments (query syntax):");
        foreach (var item in joinedQuery)
            Console.WriteLine($"{item.Name} works in {item.DepartmentName}");

        Console.WriteLine();

        // 6. Операция Aggregate (агрегирование)
        // Методный синтаксис
        var sumMethod = numbers.Aggregate((a, b) => a + b);
        Console.WriteLine($"Sum of numbers (method syntax): {sumMethod}");

        // Запросный синтаксис
        // Для запроса `Aggregate` нет прямого аналога в запросном синтаксисе, поэтому используется только методный синтаксис.

        Console.WriteLine();

        // 7. Операция Take (выборка первых N элементов)
        // Методный синтаксис
        var firstThreeNumbersMethod = numbers.Take(3);
        Console.WriteLine("First 3 numbers (method syntax):");
        foreach (var num in firstThreeNumbersMethod)
            Console.WriteLine(num);

        // Запросный синтаксис
        var firstThreeNumbersQuery = (from n in numbers
                                      select n).Take(3);
        Console.WriteLine("\nFirst 3 numbers (query syntax):");
        foreach (var num in firstThreeNumbersQuery)
            Console.WriteLine(num);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Department
{
    public string PersonName { get; set; }
    public string DepartmentName { get; set; }
}