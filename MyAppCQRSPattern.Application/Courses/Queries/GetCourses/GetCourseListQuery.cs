using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.Application.Courses.Queries.GetCourses
{
    public class GetCourseListQuery : IRequest<IEnumerable<GetCourseListQueryDto>> { }
    public class GetCourseListQueryHandler : IRequestHandler<GetCourseListQuery, IEnumerable<GetCourseListQueryDto>>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetCourseListQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetCourseListQueryDto>> Handle(GetCourseListQuery request, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Courses
                                      .Include(c => c.MainMenuItem)
                                      .ProjectTo<GetCourseListQueryDto>(_mapper.ConfigurationProvider)
                                      .ToListAsync(cancellationToken);
        }
    }
}
