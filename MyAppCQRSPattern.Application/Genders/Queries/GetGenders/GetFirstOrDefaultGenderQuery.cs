using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Genders.Queries.GetGenders
{
    public class GetFirstOrDefaultGenderQuery : IRequest<Gender>
    {
        public GetFirstOrDefaultGenderQuery(Gender gender)
        {
            Gender = gender;
        }
        public Gender Gender { get; }
    }

    public class GetFirstOrDefaultGenderQueryHandler : IRequestHandler<GetFirstOrDefaultGenderQuery, Gender>
    {
        private readonly IApplicationDbContext _appDbContext;
        public GetFirstOrDefaultGenderQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        public async Task<Gender> Handle(GetFirstOrDefaultGenderQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.Genders.FirstOrDefaultAsync(g => g.GenderId == request.Gender.GenderId, cancellationToken);
        }
    }
}
