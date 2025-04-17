namespace Lesson14.OOP_Demo.Inheritance
{
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager (string name, int teamSize) : base(name)
        {
            TeamSize = teamSize;
        }

        public override void Work ()
        {
            base.Work();
            Console.WriteLine("Manager is managing the team");
        }

        public new void TakeBreak ()
        {
            Console.WriteLine("Manager is having a strategic break");
        }
    }
}
