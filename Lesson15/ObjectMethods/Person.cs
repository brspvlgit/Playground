namespace Lesson15.ObjectMethods
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString ()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals (object obj)
        {
            if (obj is Person otherPerson)
            {
                return FirstName == otherPerson.FirstName && LastName == otherPerson.LastName;
            }
            return false;
        }

        public override int GetHashCode ()
        {
            return (FirstName, LastName).GetHashCode();
        }

        public Person CreateShallowCopy ()
        {
            return (Person)this.MemberwiseClone();
        }

        public void UseStandardObjectMethods ()
        {
            object obj = new Person("Jane", "Smith");
            Console.WriteLine("Standard ToString: " + obj.ToString());

            object obj2 = new Person("Jane", "Smith");
            Console.WriteLine("Standard Equals: " + obj.Equals(obj2));

            Console.WriteLine("Standard GetHashCode: " + obj.GetHashCode());
        }

        public void UseOverriddenObjectMethods ()
        {
            Console.WriteLine("Overridden ToString: " + ToString());

            Person person1 = new Person("John", "Doe");
            Person person2 = new Person("John", "Doe");

            Console.WriteLine("Overridden Equals: " + person1.Equals(person2));
            Console.WriteLine("Overridden GetHashCode: " + person1.GetHashCode());
        }
    }
}
