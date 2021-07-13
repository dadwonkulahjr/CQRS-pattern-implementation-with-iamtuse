using MediatR;
using MyAppCQRSPattern.Application.Common.Exceptions;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Courses.Commands.DeleteCourse
{
    public class DeleteCourseListCommand : IRequest<Course>
    {
        public DeleteCourseListCommand(Course course)
        {
            Course = course;
        }
        public Course Course { get; }
    }

    public class DeleteCourseListCommandHandler : IRequestHandler<DeleteCourseListCommand, Course>
    {
        private readonly IApplicationDbContext _appDbContext;
        public DeleteCourseListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Course> Handle(DeleteCourseListCommand request, CancellationToken cancellationToken)
        {
            var findEntity = await _appDbContext.Courses.FindAsync(request.Course.CourseId);
            if (findEntity != null)
            {
                _appDbContext.Courses.Remove(findEntity);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return findEntity;
            }
            else
            {
                throw new NotFoundException(nameof(Course), request.Course.CourseId);
            }
        }
    }
}
