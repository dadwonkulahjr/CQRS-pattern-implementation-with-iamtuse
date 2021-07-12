using MediatR;
using MyAppCQRSPattern.Application.Common.Exceptions;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Students.Commands.DeleteStudent
{
    public class DeleteStudentListCommand : IRequest<Student>
    {
        public DeleteStudentListCommand(Student student)
        {
            Student = student;
        }

        public Student Student { get; }
    }

    public class DeleteStudentListCommandHandler : IRequestHandler<DeleteStudentListCommand, Student>
    {
        private readonly IApplicationDbContext _appDbContext;
        public DeleteStudentListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Student> Handle(DeleteStudentListCommand request, CancellationToken cancellationToken)
        {
            var findEntity = await _appDbContext.Students.FindAsync(request.Student.StudentId);
            if(findEntity != null)
            {
                _appDbContext.Students.Remove(findEntity);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return findEntity;
            }
            else
            {
                throw new NotFoundException(nameof(Student), request.Student.StudentId);
            }
        }
    }
}
