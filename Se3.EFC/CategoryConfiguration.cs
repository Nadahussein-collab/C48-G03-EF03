using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Se3.EFC
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(500);

            builder.HasOne(c => c.ParentCategory)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(c => c.ParentCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Category { Id = 1, Name = "Programming", Description = "Software development courses" },
                new Category { Id = 2, Name = "Backend", Description = "Server-side development", ParentCategoryId = 1 },
                new Category { Id = 3, Name = "ASP.NET Core", Description = "Web APIs and MVC", ParentCategoryId = 2 },
                new Category { Id = 4, Name = "Frontend", Description = "Client-side development", ParentCategoryId = 1 },
                new Category { Id = 5, Name = "Databases", Description = "SQL and NoSQL databases", ParentCategoryId = 1 }
            );
        }
    }
}
