namespace Lesson14.OOP_Demo.Abstraction
{
    class CourseManager
    {
        public static void Populate ()
        {
            var programmingCourse = new ProgrammingCourse();

            programmingCourse.CourseName = "C# Programming Course";
            programmingCourse.StartCourse();
            programmingCourse.EndCourse();
        }
    }
}
