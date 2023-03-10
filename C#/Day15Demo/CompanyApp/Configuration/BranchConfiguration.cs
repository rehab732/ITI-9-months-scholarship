using CompanyApp.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Configuration
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> modelBuilder)
        {
            modelBuilder.Property(c => c.Name).HasMaxLength(20);
            modelBuilder.Property(c => c.City).HasMaxLength(10).IsUnicode();





        }
    }
}
