namespace Lesson14.OOP_Demo.Inheritance
{
    class Student : Person
    {
        public int Grade { get; set; }
        public override string Skill => "Studying";

        public Student (string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            Console.WriteLine("Student(string name, int age, int grade)");
        }

        public new void ShowDetails ()
        {
            //base.ShowDetails();
            Console.WriteLine($"Student: Name: {Name}, Age: {Age}, Grade: {Grade}, Skill: {Skill}");
        }

        public void Run ()
        {

        }
    }
}
