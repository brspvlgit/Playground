namespace Lesson14.OOP_Demo.Inheritance
{
    class PersonManager
    {
        public static void Populate ()
        {
            Student student = new Student("Alice", 20, 10);
            Person student2 = new Student("Bob", 31, 5);

            student.ShowDetails();
        }
    }
}
