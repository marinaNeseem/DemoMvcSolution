using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.DataAccess.Data.Confgurations
{
    public class BaseEntityConfgurations<T>:IEntityTypeConfiguration<T> where T : BaseEntity
    {
       
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GETDATE()");

            builder.Property(D => D.LastModifaiedOn)
            .IsRequired()
            .ValueGeneratedOnUpdate() // Ensures EF updates this on modification
            .HasDefaultValueSql("GETDATE()"); // Sets default value for existing rows
        }
    }
}
