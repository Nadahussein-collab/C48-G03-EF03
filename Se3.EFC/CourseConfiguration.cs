using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Se3.EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se3.EFC
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Description).HasMaxLength(1000);
            builder.Property(c => c.Price).HasPrecision(18, 2);

            builder.HasOne(c => c.Instructor)
                   .WithMany(i => i.Courses)
                   .HasForeignKey(c => c.InstructorId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Category)
                   .WithMany(cat => cat.Courses)
                   .HasForeignKey(c => c.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Course { Id = 1, Title = "C# Basics", Description = "Learn C# from scratch", Price = 49.99m, Level = CourseLevel.Beginner, IsPublished = true, PublishedDate = DateTime.UtcNow.AddDays(-30), InstructorId = 1, CategoryId = 1 },
                new Course { Id = 2, Title = "Advanced EF Core", Description = "Master Entity Framework Core", Price = 99.99m, Level = CourseLevel.Advanced, IsPublished = true, PublishedDate = DateTime.UtcNow.AddDays(-15), InstructorId = 2, CategoryId = 3 },
                new Course { Id = 3, Title = "ASP.NET Core Web API", Description = "Build robust REST APIs", Price = 79.99m, Level = CourseLevel.Intermediate, IsPublished = true, PublishedDate = DateTime.UtcNow.AddDays(-10), InstructorId = 2, CategoryId = 3 },
                new Course { Id = 4, Title = "React Fundamentals", Description = "Build modern web apps", Price = 59.99m, Level = CourseLevel.Beginner, IsPublished = false, InstructorId = 3, CategoryId = 4 },
                new Course { Id = 5, Title = "SQL Server Mastery", Description = "Database design and optimization", Price = 89.99m, Level = CourseLevel.Intermediate, IsPublished = true, PublishedDate = DateTime.UtcNow.AddDays(-5), InstructorId = 1, CategoryId = 5 },
                new Course { Id = 6, Title = "Algorithms & Data Structures", Description = "Level up your coding skills", Price = 120.00m, Level = CourseLevel.Advanced, IsPublished = false, InstructorId = 1, CategoryId = 1 }
            );
        }
    }
}
