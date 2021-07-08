using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MainMenuItem> MainMenuItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
