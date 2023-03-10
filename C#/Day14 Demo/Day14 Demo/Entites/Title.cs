using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Demo.Entites
{
    public class Title
    {
        public int ID { get; set; } //PK  identity
        public  string AuthorName { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string? Forward { get; set; } //enable nullable by default
        public decimal? PromotionalPrice { get; set; }//also allow nulls 
        public virtual Branch? Baranch { get; set; }
        //el7al
        /*
         * 1 constructor
         * 2 required keyword 
         * 4 = string.Empty;
         */
       
    }
}
