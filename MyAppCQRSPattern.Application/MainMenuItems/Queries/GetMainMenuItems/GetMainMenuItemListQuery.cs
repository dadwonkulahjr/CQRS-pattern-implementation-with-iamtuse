using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.MainMenuItems.Queries.GetMainMenuItems
{
    public class GetMainMenuItemListQuery : IRequest<IEnumerable<GetMainMenuItemListQueryDto>> { }

    public class GetMainMenuItemListQueryHandler : IRequestHandler<GetMainMenuItemListQuery, IEnumerable<GetMainMenuItemListQueryDto>>
    {
        private readonly IApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;
        public GetMainMenuItemListQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _appDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetMainMenuItemListQueryDto>> Handle(GetMainMenuItemListQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.MainMenuItems
                                     .Include(m => m.Student)
                                     .ThenInclude(m => m.Gender)
                                     .Include(m => m.Course)
                                     .ProjectTo<GetMainMenuItemListQueryDto>(_mapper.ConfigurationProvider)
                                     .ToListAsync();
            
        }
    }
}
