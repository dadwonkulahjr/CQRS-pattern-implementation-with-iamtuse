using MediatR;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Courses.Commands.UpdateCourse
{
    public class UpdateCourseListCommand : IRequest<Course>
    {
        public UpdateCourseListCommand(Course course)
        {
            Course = course;
        }
        public Course Course { get; }
    }
    public class UpdateCourseListCommandHandler : IRequestHandler<UpdateCourseListCommand, Course>
    {
        private readonly IApplicationDbContext _appDbContext;
        public UpdateCourseListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Course> Handle(UpdateCourseListCommand request, CancellationToken cancellationToken)
        {
            var findCourseFromDb = await _appDbContext.Courses.FindAsync(request.Course.CourseId);
            if (findCourseFromDb != null)
            {
                findCourseFromDb.CourseName = request.Course.CourseName;
                findCourseFromDb.CourseNumber = request.Course.CourseNumber;
                findCourseFromDb.CreditHour = request.Course.CreditHour;
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return findCourseFromDb;

            }
            return null;
        }
    }
}
