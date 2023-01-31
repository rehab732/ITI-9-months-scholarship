using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Book
    {
        public string? isbn,title;
        public DateTime publictionDate;
        public decimal price;
        public string[]? auther;
        public string[] Auther
        {
            get => auther;
            set => auther = value;
        }
        public string Isbn
        {
            get => isbn;
            set => isbn = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public DateTime PublictionDate
        {
            get => publictionDate;
            set => publictionDate = value;
        }
        public decimal Price
        {
            get => price;   
            set => price = value;
        }
        public Book(string i,string t,DateTime date, string[] _Authors,decimal p)
        {
           this.isbn = i;
            this.title = t;
            this.publictionDate = date;
            this.price = p;
            this.auther = _Authors;

        }
        public override string ToString()=> $"{isbn}/{title}/{publictionDate}/{price}/{auther}";
       
    }
}
