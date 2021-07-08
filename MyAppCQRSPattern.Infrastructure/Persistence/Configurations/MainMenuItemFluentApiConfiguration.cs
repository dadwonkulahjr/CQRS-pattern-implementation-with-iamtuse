using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyAppCQRSPattern.Domain.Entities;

namespace MyAppCQRSPattern.Infrastructure.Persistence.Configurations
{
    public class MainMenuItemFluentApiConfiguration : IEntityTypeConfiguration<MainMenuItem>
    {
        public void Configure(EntityTypeBuilder<MainMenuItem> builder)
        {
            builder.HasKey(m => m.MainMenuId);
            builder.ToTable("tblMainMenuItem");

            builder.Property(m => m.CourseDescripion)
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(max)")
                    .IsFixedLength()
                    .IsRequired();

            builder.Property(m => m.GenderDescription)
                 .HasMaxLength(50)
                 .HasColumnType("nvarchar(max)")
                 .IsFixedLength()
                 .IsRequired();

            builder.Property(m => m.StudentDescription)
                 .HasMaxLength(50)
                 .HasColumnType("nvarchar(max)")
                 .IsFixedLength()
                 .IsRequired();

            builder.HasOne(m => m.Course)
                   .WithMany(m => m.MainMenuItem)
                   .HasForeignKey(m => m.CourseId)
                   .IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.Student)
                 .WithMany(m => m.MainMenuItem)
                 .HasForeignKey(m => m.StudentId)
                 .IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
