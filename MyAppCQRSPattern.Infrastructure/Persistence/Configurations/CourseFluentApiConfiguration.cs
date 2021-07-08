using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyAppCQRSPattern.Domain.Entities;

namespace MyAppCQRSPattern.Infrastructure.Persistence.Configurations
{
    public class CourseFluentApiConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);
            builder.ToTable("tblCourse")
                .Property(c => c.CourseName)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsFixedLength()
                .IsRequired();

            builder.Property(c => c.CourseNumber)
                   .HasColumnType("int")
                   .IsRequired().IsFixedLength();

            builder.Property(c => c.CreditHour)
                .HasColumnType("int")
                .IsRequired().IsFixedLength();

            builder.HasMany(c => c.MainMenuItem)
                    .WithOne(c => c.Course)
                    .HasForeignKey(c => c.CourseId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);
                    
        }
    }
}
