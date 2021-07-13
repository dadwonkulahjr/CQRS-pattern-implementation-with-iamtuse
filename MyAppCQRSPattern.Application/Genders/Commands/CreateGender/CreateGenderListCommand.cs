using MediatR;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Genders.Commands.CreateGender
{
    public class CreateGenderListCommand : IRequest<Gender>
    {
        public CreateGenderListCommand(Gender gender)
        {
            Gender = gender;
        }
        public Gender Gender { get; }
    }

    public class CreateGenderListCommandHandler : IRequestHandler<CreateGenderListCommand, Gender>
    {
        private readonly IApplicationDbContext _appDbContext;
        public CreateGenderListCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Gender> Handle(CreateGenderListCommand request, CancellationToken cancellationToken)
        {
            await _appDbContext.Genders.AddAsync(request.Gender, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return request.Gender;
        }
    }
}
