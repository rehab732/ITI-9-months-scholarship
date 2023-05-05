using Day2_3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_3.DataAccess
{
   public class SchoolDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6Q07NG7\SQLEXPRESS;Initial Catalog=MVVMDay_2;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
}
