
namespace Day8
{

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
        , User_delg fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}