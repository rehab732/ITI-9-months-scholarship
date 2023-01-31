using Day8;

internal partial class Program
{
    public class BookFunction
    {
        public static string GetTitle(Book B) => B.title;

        public static string[] GetAuthors(Book B) => B.auther;

        public static string GetPrice(Book B) => B.price.ToString();
        public static string GetIsbn(Book B) => B.isbn;

    }
}