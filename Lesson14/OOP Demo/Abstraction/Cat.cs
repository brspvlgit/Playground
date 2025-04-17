namespace Lesson14.OOP_Demo.Abstraction
{
    class Cat : Animal
    {
        private string name;
        public override string Name => name;

        public Cat (string name)
        {
            this.name = name;
        }

        public override void MakeSound ()
        {
            Console.WriteLine("Meow!");
        }
    }
}
