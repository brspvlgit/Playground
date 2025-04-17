namespace Lesson15.Enums
{
    public enum Fruit
    {
        Apple = 3,
        Banana,
        Orange,
        Mango
    }

    static class FruitHelper
    {
        public static void Run ()
        {
            Fruit favoriteFruit = Fruit.Mango;

            Console.WriteLine("My favorite fruit is: " + favoriteFruit);
            Console.WriteLine("Int value of favorite fruit: " + (int)favoriteFruit);
        }
    }
}
