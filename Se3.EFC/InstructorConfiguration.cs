using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se3.EFC
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.FullName).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(150);
            builder.Property(i => i.Bio).HasMaxLength(1000);

            builder.HasData(
                new Instructor { Id = 1, FullName = "Moustafa Saad", Email = "moustafa@example.com", Bio = "Competitive programming expert", JoinedDate = DateTime.UtcNow.AddYears(-2) },
                new Instructor { Id = 2, FullName = "John Doe", Email = "john@example.com", Bio = ".NET Architect", JoinedDate = DateTime.UtcNow.AddYears(-1) },
                new Instructor { Id = 3, FullName = "Jane Smith", Email = "jane@example.com", Bio = "Frontend Lead", JoinedDate = DateTime.UtcNow.AddMonths(-6) }
            );
        }
    }
}
