using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyAppCQRSPattern.Domain.Entities;

namespace MyAppCQRSPattern.Infrastructure.Persistence.Configurations
{
    public class StudentFluentApiConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);
            builder.ToTable("tblStudent");
            builder.Ignore(s => s.FullName);

            builder.Property(s => s.FirstName)
                   .HasMaxLength(50)
                   .HasColumnType("varchar(50)")
                   .IsFixedLength()
                   .IsRequired();

            builder.Property(s => s.LastName)
                 .HasMaxLength(50)
                 .HasColumnType("varchar(50)")
                 .IsFixedLength()
                 .IsRequired();

            builder.Property(s => s.Email)
                 .HasMaxLength(50)
                 .HasColumnType("varchar(50)")
                 .IsFixedLength()
                 .IsRequired();


            builder.Property(s => s.DateEnrolled)
                .HasMaxLength(50)
                .HasColumnType("datetime2")
                .IsFixedLength()
                .IsRequired();

            builder.HasOne(s => s.Gender)
                    .WithMany(s => s.Student)
                    .HasForeignKey(s => s.GenderId)
                    .OnDelete(DeleteBehavior.NoAction);



            builder.HasMany(s => s.MainMenuItem);
                   
                   




        }
    }
}
