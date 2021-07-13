using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Exceptions;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Students.Commands.UpdateStudent
{
    public class UpdateStudentListCommand : IRequest<Student>
    {
        public UpdateStudentListCommand(Student student)
        {
            Student = student;
        }

        public Student Student { get; }
    }

    public class UpdateStudentListCommandHandler : IRequestHandler<UpdateStudentListCommand, Student>
    {
        private readonly IApplicationDbContext _appDbContext;
        public UpdateStudentListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Student> Handle(UpdateStudentListCommand request, CancellationToken cancellationToken)
        {
            var checkStudentInDb = await _appDbContext.Students.FirstOrDefaultAsync(s => s.StudentId == request.Student.StudentId, cancellationToken);
            if (checkStudentInDb != null)
            {
                checkStudentInDb.FirstName = request.Student.FirstName;
                checkStudentInDb.LastName = request.Student.LastName;
                checkStudentInDb.Email = request.Student.Email;
                checkStudentInDb.DateEnrolled = request.Student.DateEnrolled;
                checkStudentInDb.GenderId = request.Student.GenderId;
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return checkStudentInDb;
            }
            else
            {
                throw new NotFoundException(nameof(Student), request.Student.StudentId);
            }
        }
    }
}
