namespace Lesson13;

internal class Program
{
    static void Main (string[] args)
    {
        //Superhero thor = new Superhero("Тор", "Молния", 80, 11);
        //Superhero spiderman = new Superhero("Человек паук", "Паутина", 50, 11);
        //Superhero john = new Superhero();

        //thor.Display();
        //spiderman.Display();
        //john.Display();

        //thor.Fight(30);
        //spiderman.Fight(20);

        //int extraStrength = 10;
        //thor.Train(ref extraStrength);

        //Console.WriteLine(thor.GetHeroStats());
        //Console.WriteLine(spiderman.GetHeroStats());

        //Console.WriteLine($"Количество героев: {Superhero.GetHeroCount()}");

        //var notebook = new Product(1, "Notebook", 1000m);
        //var mouse = new Product(1, "Mouse", 10m);

        //var order = new Order(101, "Иван Иванов", new List<Product> { notebook });

        //order.AddItem(mouse);

        //order.DisplayOrderInfo();

        Author author1 = new Author("J.K. Rowling", 1965);
        Author author2 = new Author("J.R.R. Tolkien", 1892);

        Book book1 = new Book("Harry Potter and the Sorcerer's Stone", author1, 20.99);
        Book book2 = new Book("The Hobbit", author2, 15.99);

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        library.DisplayLibraryInfo();

        Console.WriteLine($"Total price: {library.GetTotalPrice():F2}");
    }
}
