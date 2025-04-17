namespace Lesson14.OOP_Demo
{
    class Teacher : Person
    {
        public string Subject { get; } // Инкапсуляция : свойство доступно только для чтения

        public Teacher (string name, int birthYear, string subject) : base(name, birthYear)
        {
            Subject = subject;
        }

        // Полиморфизм: реализация метода для учителя
        public override void IntroduceYourself ()
        {
            Console.WriteLine($"Здравствуйте, я учитель {Name}, мне {Age} лет, я преподаю {Subject}.");
        }
    }
}
