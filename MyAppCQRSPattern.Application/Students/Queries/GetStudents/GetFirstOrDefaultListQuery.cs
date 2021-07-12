using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Students.Queries.GetStudents
{
    public class GetFirstOrDefaultListQuery : IRequest<Student>
    {
        public GetFirstOrDefaultListQuery(Student student)
        {
            Student = student;
        }

        public Student Student { get; }
    }

    public class GetFirstOrDefaultListQueryHandler : IRequestHandler<GetFirstOrDefaultListQuery, Student>
    {
        private readonly IApplicationDbContext _appDbContext;
        public GetFirstOrDefaultListQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }

        public async Task<Student> Handle(GetFirstOrDefaultListQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.Students.FirstOrDefaultAsync(s => s.StudentId == request.Student.StudentId);
          
        }
    }
}
