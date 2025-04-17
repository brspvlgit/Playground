namespace Lesson13
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        private double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть отрицательной.");
                price = value;
            }
        }

        public Book (string title, Author author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string GetBookInfo ()
        {
            return $"{Title} by {Author.Name}, Price: {Price:C}";
        }
    }
}
