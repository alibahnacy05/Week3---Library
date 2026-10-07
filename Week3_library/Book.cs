namespace Week3_library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
    

    public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine("");
        }
    }
}
