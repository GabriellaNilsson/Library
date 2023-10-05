namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of book: ");
            string title = Console.ReadLine();

            Console.WriteLine("Author of book: ");
            string author = Console.ReadLine();

            Console.WriteLine("Summary of book: ");
            string summary = Console.ReadLine();

            Book myBook = new Book(title, author, summary);

            myBook.PrintInfo();

        }

}    }