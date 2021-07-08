using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyAppCQRSPattern.Domain.Entities;

namespace MyAppCQRSPattern.Infrastructure.Persistence.Configurations
{
    public class GenderFluentApiConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(g => g.GenderId);
            builder.ToTable("tblGender");


            builder.Property(g => g.Name)
               .HasMaxLength(50)
               .HasColumnType("varchar(50)")
               .IsRequired()
               .IsFixedLength();

            builder.HasMany(g => g.Student)
                    .WithOne(g => g.Gender)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(g => g.GenderId);
        }
    }
}
