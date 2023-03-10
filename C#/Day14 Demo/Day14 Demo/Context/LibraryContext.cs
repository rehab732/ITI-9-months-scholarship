using Day14_Demo.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Demo.Context
{
    internal class LibraryContext:DbContext
    {
        //define database you need to connect on it 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Library;Integrated Security=true;Encrypt=false");


        /// <summary>
        /// local copy from title table 
        /// offline copy from database 
        /// 
        /// </summary>
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
         


        //Newer style --> public DbSet<Title> titl => Set<Title>();
    }

}
