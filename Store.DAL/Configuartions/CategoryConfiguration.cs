using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Configuartions
{
    public class CategoryConfiguration :IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name)
                  .IsUnique();
            builder.Property(x => x.Name)
                .HasMaxLength(32);
            builder.Property(x => x.Icon)
                .HasMaxLength(128);
            builder.HasMany(x => x.Products)
                .WithOne(y => y.Category)
                .HasForeignKey(z => z.CategoryId);
        }

          
    }
}
