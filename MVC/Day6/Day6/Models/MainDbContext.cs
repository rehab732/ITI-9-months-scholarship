using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day6.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base("myconn")
        { }
            public DbSet<User> users { get; set; }
    }
    
}