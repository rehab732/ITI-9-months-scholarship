using CompanyApp.Configuration;
using CompanyApp.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Context
{
    internal class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=CompanySd43;Integrated Security=true;Encrypt=false");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());

            base.OnModelCreating(modelBuilder);



        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }

    }
}
