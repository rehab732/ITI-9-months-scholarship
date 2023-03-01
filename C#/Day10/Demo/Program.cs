using Day10;
using static Day10.ListGenerators;
internal class Program
{
    private static void Main(string[] args)
    {
        /*
        double n = 12.15;
        Console.WriteLine(n.GetType().Name);
        var E = new{ ID = 1000, salary = 12 };
        Console.WriteLine(E.GetType().Name);
        Console.WriteLine(E);

        ////Linq
        List<int> lst=new List<int>() { 1,2,3,4,5,6,7,8,9,10};

        //way1 static method
        //var result = Enumerable.Where(lst, X => X % 2 == 0);
       

        //way2 extention  method
       // var result=lst.Where(X=> X % 2 == 0);

        //way1 query method
        var result=from x in lst
                   where x%2 == 0
                   select x;
        lst.AddRange(new int[] {11,12,13,14});
         foreach (var i in result)
        {
            Console.WriteLine(i);
        }
         Console.WriteLine("================");
        lst.Remove(2);
        lst.Remove(4);
        lst.Add(18);
        lst.Add(20);
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
        */
        #region Filtaration
        /*
        var res = from p in ProductList
                  where p.UnitsInStock == 0
                  select p;
        res = ProductList.Where((p, index) => (index < 10) && (p.UnitsInStock == 0));
        foreach (var i in res)
        {
            Console.WriteLine(i);
        }*/
        #endregion
        #region Select
        /*
        var re = ProductList.Where(p => p.UnitsInStock == 0).Select(p => new{yourproductname=p.ProductName,productCategory=p.Category});
        //way 2 indexed 
        var result = ProductList.Where(p => p.UnitsInStock == 0).Select((p, index) => new {Number=index+1,Name=p.ProductName});
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }*/
        #endregion
        #region Select Many
        /*
        List<String> lstNames= new List<String>() { "Rehab zaki","Mahmoud Mohamed","Mohamed Zaki"};
        var names = from fullname in lstNames
                    from name in fullname.Split(" ")
                    where name.Length >= 2
                    select name;

        //way 2 using select many
        names = lstNames.SelectMany(fullname => fullname.Split(" ")).Where(name => name.Length >= 5);

        foreach (var i in names)
        {
            Console.WriteLine(i);
        }*/
        #endregion
        #region OrderBy
        /*var res = ProductList.Where(p => p.UnitsInStock != 0)
            .OrderBy(p => p.UnitPrice)
            .ThenByDescending(p=>p.UnitsInStock);
        foreach (var i in res)
        {
            Console.WriteLine(i);
        }*/

        #endregion
        #region Single element (firs,last,element At,single)
        /*var r = ProductList.First();
        Console.WriteLine(r);
        //way 2 by predicate 
        var tt = ProductList.OrderBy(p=>p.UnitsInStock).First(p => p.UnitPrice > 50);
        Console.WriteLine(tt);
        */
        //var result = ProductList.Where(p => p.UnitPrice > 10).ElementAt(5);
       //Console.WriteLine(result);

        List<Product> discountprodect = new List<Product>();
        // discountprodect.Add(ProductList.FirstOrDefault());
        //var result = discountprodect.SingleOrDefault();
        //Console.WriteLine(result);

        #endregion
        #region Aggregate (cout, max,min,sum)
        // var e = ProductList.Count();
        //Console.WriteLine(e);
        //pass predicate
        //var ee = ProductList.Count(p=>p.UnitPrice>50);
        //Console.WriteLine(ee);
        //var re = ProductList.Max();//based on unit in stock
        //Console.WriteLine(re);
        //query way
        /*var tryy=(from p in ProductList
                 where p.UnitPrice==ProductList.Max(p=>p.UnitPrice)
                 select p).FirstOrDefault();
        Console.WriteLine(tryy.ProductName);

        var sum=ProductList.Sum(p=>p.UnitPrice);
        Console.WriteLine(sum);*/

        #endregion
        #region Slicing(take,skip,takeLast,skipLast,takewhile,skipwhile)
        /*
        var p=ProductList.Take(10);
        var l = ProductList.SkipLast(70);
        foreach(var i in p)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("================");
        foreach (var i in l)
        {
            Console.WriteLine(i);
        }*/
        #endregion
        #region Generators(range,empty,repeat)
        //must call them by enumerable
        /*var lst=Enumerable.Range(1,10);
        foreach(var i in lst)
        {
            Console.WriteLine(i);
        }
        */
        #endregion
        #region Set operators
        /* var lst = Enumerable.Range(0, 100);
         var lst2 = Enumerable.Range(50, 100);
         var inter = lst.Intersect(lst2);


         foreach (var i in inter)
         {
             Console.WriteLine(i);
         }*/
        #endregion
        #region Grouping
        var result = from p in ProductList
                     where p.UnitsInStock > 0
                     group p by p.Category;
        Console.WriteLine(result.GetType().Name);
        #endregion


    }
}