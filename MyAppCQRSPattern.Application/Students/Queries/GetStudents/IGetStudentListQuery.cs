using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Students.Queries.GetStudents
{
    public interface IGetStudentListQuery
    {
        Task<IEnumerable<Student>> Handle();
    }

    public class GetStudentQuery : IGetStudentListQuery
    {
        private readonly IApplicationDbContext _appDbContext;
        public GetStudentQuery(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<IEnumerable<Student>> Handle()
        {
            return await _appDbContext.Students.ToListAsync();
        }
    }
}
