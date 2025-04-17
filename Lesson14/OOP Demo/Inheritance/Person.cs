namespace Lesson14.OOP_Demo.Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Skill { get; set; } = string.Empty;

        public Person (string name)
        {
            Name = name;
            Console.WriteLine("Person(string name)");
        }

        public Person (string name, int age) : this(name)
        {
            Age = age;
            Console.WriteLine("Person(string name, int age)");
        }

        public virtual void ShowDetails ()
        {
            Console.WriteLine($"Person: Name: {Name}, Age: {Age}, Skill: {Skill}");
        }
    }
}
