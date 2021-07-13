using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Courses.Queries.GetCourses
{
    public class GetFirstOrDefaultCourseQuery : IRequest<Course>
    {
        public GetFirstOrDefaultCourseQuery(Course course)
        {
            Course = course;
        }
        public Course Course { get; }
    }

    public class GetFirstOrDefaultCourseQueryHandler : IRequestHandler<GetFirstOrDefaultCourseQuery, Course>
    {
        private readonly IApplicationDbContext _appDbContext;
        public GetFirstOrDefaultCourseQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Course> Handle(GetFirstOrDefaultCourseQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.Courses.FirstOrDefaultAsync(c => c.CourseId == request.Course.CourseId);
        }
    }
}
