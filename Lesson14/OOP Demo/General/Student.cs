namespace Lesson14.OOP_Demo
{
    class Student : Person
    {
        public string Major { get; } // Инкапсуляция : свойство доступно только для чтения

        public Student (string name, int birthYear, string major) : base(name, birthYear)
        {
            Major = major;
        }

        // Полиморфизм: реализация метода для студента
        public override void IntroduceYourself ()
        {
            Console.WriteLine($"Привет, я студент {Name}, мне {Age} лет, изучаю {Major}.");
        }
    }
}
