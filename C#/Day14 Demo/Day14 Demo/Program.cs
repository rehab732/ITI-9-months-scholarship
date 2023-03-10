using Day14_Demo.Context;
using Day14_Demo.Entites;

internal class Program
{
    private static void Main(string[] args)
    {
        using (LibraryContext context= new LibraryContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();//create db if not created 
            /////insert
            Title title = new() { AuthorName = "Rehab", Price = 1212,PromotionalPrice=12 };//untile now this object not attached in database
            //Console.WriteLine(context.Entry(title).State);//deattached

            //a dd it to local copy
            context.Titles.Add(title);
            //Console.WriteLine(context.Entry(title).State);//Added
            //commit changes into database 
            //Console.WriteLine(context.Entry(title).State);//unchanged

            //Console.WriteLine(title.ID);

            ////update
            /*var result=(from T in context.Titles
                       where T.PromotionalPrice==null
                       select T).First();
            result.PromotionalPrice = 0.75M*result.Price;*/

            /////delete
            /* var n = context.Titles.FirstOrDefault(x => x.AuthorName == "Rehab");
             if (n != null)
                 context.Remove(n);*/
            Branch Branch = new() {City="Cairo",Zipcode="0000"};//untile now this object not attached in database


              context.SaveChanges();//transactional by default and return number of rows effeced



            /*
            var re = context.Titles.FirstOrDefault();
            Console.WriteLine(re?.AuthorName??"Not Available");*/
        }

    }
}
//dispose remove un managed resources