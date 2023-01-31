
using static System.Reflection.Metadata.BlobBuilder;

namespace Day8
{
    public delegate string User_delg(Book b);

    internal partial class Program
    {
        private static void Main(string[] args)
        {
            string[] Authers = new string[] { "Rehab", "Zaki" };
            DateTime n =DateTime.Now;
            Book b1 = new Book("123","Book1",n,Authers,1235);
            Book b2 = new Book("2235", "Book2", n, Authers, 454546);
            Book b3 = new Book("12553", "Book3", n, Authers, 46462);
            List<Book> b = new List<Book>();
            b.Add(b1);
            b.Add(b2);
            b.Add(b3);

            //Anonumes 
            User_delg user = delegate (Book b)
            {
                return b.isbn;
            };
            LibraryEngine.ProcessBooks(b, user);
            user = delegate (Book b)
            {
                return b.price.ToString();
            };
            LibraryEngine.ProcessBooks(b, user);

            user = delegate (Book b)
            {
                return b.title;
            };
            LibraryEngine.ProcessBooks(b, user);

            //by func
          

            Func<Book, string> func;

            func = delegate (Book b) { return b.isbn; };
            LibraryEngine.ProcessBooks(b, func.Invoke);


            Console.WriteLine();
            func = delegate (Book b) { return b.Price.ToString(); };
            LibraryEngine.ProcessBooks(b, func.Invoke);


            Console.WriteLine();
            func = delegate (Book b) { return b.publictionDate.ToString(); };
            LibraryEngine.ProcessBooks(b, func.Invoke);

            //lamda expression


            func = b => b.isbn;
            LibraryEngine.ProcessBooks(b, func.Invoke);

            Console.WriteLine();
            func = b => b.Price.ToString();
            LibraryEngine.ProcessBooks(b, func.Invoke);


            Console.WriteLine();
            func = b => b.publictionDate.ToString();
            LibraryEngine.ProcessBooks(b, func.Invoke);




        }
    }
}