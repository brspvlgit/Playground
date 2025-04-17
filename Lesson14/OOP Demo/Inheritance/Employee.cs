namespace Lesson14.OOP_Demo.Inheritance
{
    class Employee
    {
        public virtual string Name { get; set; }
        public string FullName { get; set; }

        public Employee (string name)
        {
            Name = name;
        }

        public virtual void Work ()
        {
            Console.WriteLine("Employee is working");
        }

        public void TakeBreak ()
        {
            Console.WriteLine("Employee is taking a break");
        }
    }
}
