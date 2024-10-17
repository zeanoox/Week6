namespace Assignment2
{
    internal class Book
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public void Display()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
        }
    }
}
