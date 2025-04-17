namespace Lesson14.OOP_Demo.Abstraction
{
    abstract class Course
    {
        // Абстрактное свойство для имени курса
        public abstract string CourseName { get; set; }

        // Абстрактный метод для начала курса
        public abstract void StartCourse ();

        // Не абстрактный метод для завершения курса
        public void EndCourse ()
        {
            Console.WriteLine($"{CourseName} ended.");
        }
    }
}
