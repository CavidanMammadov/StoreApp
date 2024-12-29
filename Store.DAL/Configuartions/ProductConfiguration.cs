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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired();
            builder.Property(x => x.Name)   
                .HasMaxLength(128);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1024);
            builder.Property(x => x.SellPrice)
                .IsRequired();
            builder.Property(x => x.CostPrice)
                .IsRequired();
            builder.HasMany(x => x.Tags)
                .WithMany(y => y.Products);




        }
    }
}
