namespace Lesson15.ObjectMethods
{
    class PersonHelper
    {
        public void Run ()
        {
            Person person = new Person("John", "Doe");

            Console.WriteLine("=== Standard Object Methods ===");
            person.UseStandardObjectMethods();

            Console.WriteLine("\n=== Overridden Object Methods ===");
            person.UseOverriddenObjectMethods();

            Person shallowCopyPerson = person.CreateShallowCopy();
            Console.WriteLine("\nShallow Copy: " + shallowCopyPerson.ToString());
        }
    }
}
