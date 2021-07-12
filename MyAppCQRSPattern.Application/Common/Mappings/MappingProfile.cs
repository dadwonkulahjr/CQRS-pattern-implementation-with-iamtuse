using AutoMapper;
using MyAppCQRSPattern.Application.Students.Queries.GetStudents;


namespace MyAppCQRSPattern.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            new GetStudentListQueryDto()
                .Mapping(this);
        }


        
    }
}
