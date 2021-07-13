using MediatR;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Courses.Commands.CreateCourse
{
    public class CreateCourseListCommand : IRequest<Course>
    {
        public CreateCourseListCommand(Course course)
        {
            Course = course;
        }
        public Course Course { get; }
    }
    public class CreateCourseListCommandHandler : IRequestHandler<CreateCourseListCommand, Course>
    {
        private readonly IApplicationDbContext _appDbContext;
        public CreateCourseListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Course> Handle(CreateCourseListCommand request, CancellationToken cancellationToken)
        {
            await _appDbContext.Courses.AddAsync(request.Course, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return request.Course;
        }
    }


}
