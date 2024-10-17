namespace Assignment2
{
    internal class Book
    {
        private string Title;
        private string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Display()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
        }
    }
}
