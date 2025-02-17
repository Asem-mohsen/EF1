using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity.Configrations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

            builder.HasKey(i => i.ID);

            builder.Property(i => i.ID)
                   .ValueGeneratedOnAdd();

            builder.HasOne(i => i.Department)
                   .WithMany() 
                   .HasForeignKey(i => i.Dept_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
