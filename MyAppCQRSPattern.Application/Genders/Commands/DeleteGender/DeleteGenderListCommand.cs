using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Genders.Commands.DeleteGender
{
    public class DeleteGenderListCommand : IRequest<Gender>
    {
        public DeleteGenderListCommand(Gender gender)
        {
            Gender = gender;
        }
        public Gender Gender { get; }
    }
    public class DeleteGenderListCommandHandler : IRequestHandler<DeleteGenderListCommand, Gender>
    {
        private readonly IApplicationDbContext _appDbContext;
        public DeleteGenderListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Gender> Handle(DeleteGenderListCommand request, CancellationToken cancellationToken)
        {
            var findGenderFormDb = await _appDbContext.Genders.FirstOrDefaultAsync(g => g.GenderId == request.Gender.GenderId, cancellationToken);

            if(findGenderFormDb !=  null)
            {
                _appDbContext.Genders.Remove(findGenderFormDb);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return findGenderFormDb;
            }

            return null;
        }
    }
}
