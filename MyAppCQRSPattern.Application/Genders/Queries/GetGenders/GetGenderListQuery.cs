using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Genders.Queries.GetGenders
{
    public class GetGenderListQuery : IRequest<IEnumerable<GetGenderListQueryDto>> { }
    
    public class GetGenderListQueryHandler : IRequestHandler<GetGenderListQuery, IEnumerable<GetGenderListQueryDto>>
    {
        private readonly IApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;
        public GetGenderListQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _appDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetGenderListQueryDto>> Handle(GetGenderListQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.Genders
                                    .Include(g => g.Student)
                                    .ProjectTo<GetGenderListQueryDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync(cancellationToken);
        }
    }
}
