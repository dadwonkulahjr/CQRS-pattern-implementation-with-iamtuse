using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Students.Queries.GetStudents
{
    public class GetStudentListQuery : IRequest<IEnumerable<GetStudentListQueryDto>> { }
    public class GetStudentQueryHandler : IRequestHandler<GetStudentListQuery, IEnumerable<GetStudentListQueryDto>>
    {
        private readonly IApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;

        public GetStudentQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _appDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetStudentListQueryDto>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _appDbContext.Students
                                .Include(s => s.Gender)
                                .ProjectTo<GetStudentListQueryDto>(_mapper.ConfigurationProvider)
                                .ToListAsync(cancellationToken);

        }
    }
}
