using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Genders.Commands.UpdateGender
{
    public class UpdateGenderListCommand : IRequest<Gender>
    {
        public UpdateGenderListCommand(Gender gender)
        {
            Gender = gender;
        }

        public Gender Gender { get; }
    }

    public class UpdateGenderListCommandHandler : IRequestHandler<UpdateGenderListCommand, Gender>
    {
        private readonly IApplicationDbContext _appDbContext;
        public UpdateGenderListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Gender> Handle(UpdateGenderListCommand request, CancellationToken cancellationToken)
        {
            var findGenderFormDb = await _appDbContext.Genders.FirstOrDefaultAsync(g => g.GenderId == request.Gender.GenderId, cancellationToken);
            if(findGenderFormDb != null)
            {
                findGenderFormDb.Name = request.Gender.Name;
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return findGenderFormDb;
            }
            return null;
        }
    }
}
