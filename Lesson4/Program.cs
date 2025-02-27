namespace Lesson4;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("Угадайте число от 1 до 100: ");
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            var myNumber = int.Parse(Console.ReadLine());

            if (myNumber > secretNumber)
            {
                Console.WriteLine("Меньше");
            }
            else if (myNumber < secretNumber)
            {
                Console.WriteLine("Больше");
            }
            else 
            {
                Console.WriteLine("Поздравляю, вы угадали!");
            }
        }
    }