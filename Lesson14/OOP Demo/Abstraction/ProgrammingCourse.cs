namespace Lesson14.OOP_Demo.Abstraction
{
    class ProgrammingCourse : Course
    {
        // Переопределение абстрактного свойства
        public override string CourseName { get; set; }

        public int MyProperty { get; set; }

        // Переопределение абстрактного метода
        public override void StartCourse ()
        {
            Console.WriteLine($"{CourseName} started.");
        }

        public void Run ()
        {

        }
    }
}
