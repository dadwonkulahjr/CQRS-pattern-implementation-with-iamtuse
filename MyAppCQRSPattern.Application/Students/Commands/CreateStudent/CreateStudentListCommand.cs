using MediatR;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Students.Commands.CreateStudent
{
    public class CreateStudentListCommand : IRequest<Student>
    {
        public CreateStudentListCommand(Student student)
        {
            Student = student;
        }

        public Student Student { get; }
    }

    public class CreateStudentListCommandHandler : IRequestHandler<CreateStudentListCommand, Student>
    {
        private readonly IApplicationDbContext _appDbContext;
        public CreateStudentListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Student> Handle(CreateStudentListCommand request, CancellationToken cancellationToken)
        {
            await _appDbContext.Students.AddAsync(request.Student, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return request.Student;
        }
    }
}
