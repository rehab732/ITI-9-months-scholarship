using CompanyApp.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Configuration
{
    public class ClientConfiguration:IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> modelBuilder)
        {
            modelBuilder
              .Ignore(c => c.Timestamp)
            .HasKey(c => c.CID);

            modelBuilder.Property(c => c.FName).HasMaxLength(40);
            modelBuilder.Property(c => c.LName).HasMaxLength(40);
            modelBuilder.Property(c => c.MName).HasMaxLength(2).IsFixedLength().IsRequired(false);
            modelBuilder.Property(c => c.Deposit).HasColumnType("money").HasColumnName("ClientDeposit");

            /*
             * Or write like that
             *   modelBuilder.Entity<Client>()
                .HasKey("CID");
             */
        }
    }
}
