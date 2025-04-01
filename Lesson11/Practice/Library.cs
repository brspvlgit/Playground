namespace Lesson11.Practice;

public class Library
{
    public static Dictionary<int, Book> books = new Dictionary<int, Book>
    {
        { 1, new Book("To Kill a Mockingbird", "Harper Lee", 1960, 281) },
        { 2, new Book("1984", "George Orwell", 1949, 328) },
        { 3, new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 180) },
        { 4, new Book("The Lord of the Rings: The Fellowship of the Ring", "Tolkien", 1954, 423) },
        { 5, new Book("The Road", "Cormac McCarthy", 2006, 287) },
        { 6, new Book("The Hobbit", "Tolkien", 1937, 432) }
    };

    public static void BooksByAuthor()
    {
        var result = books.Values.Where(b => b.Author == "Tolkien").ToList();
        foreach (var book in result)
        {
            Console.WriteLine($"{book.Title}, {book.Author}, {book.Year}, {book.Pages})");
        }
    }
    
    public static void BookCount()
    {
        Console.WriteLine(books.Count);
    }

    public static void CountPages()
    {
        Book result = books.Values.OrderByDescending(b => b.Pages).FirstOrDefault();

        if (result != null)
        {
            Console.WriteLine($"{result.Title}, {result.Author}, {result.Year}, {result.Pages})");
        }
    }

    public static void BooksByYear()
    {
        var result = books.Values.Where(b => b.Year >= 2000).Select(b => b.Title).ToList();
        
        Console.WriteLine(string.Join(", ", result));
    }
}