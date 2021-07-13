using AutoMapper;
using MyAppCQRSPattern.Application.Courses.Queries.GetCourses;
using MyAppCQRSPattern.Application.Genders.Queries.GetGenders;
using MyAppCQRSPattern.Application.MainMenuItems.Queries.GetMainMenuItems;
using MyAppCQRSPattern.Application.Students.Queries.GetStudents;


namespace MyAppCQRSPattern.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            new GetStudentListQueryDto()
                .Mapping(this);
            new GetCourseListQueryDto()
               .Mapping(this);
            new GetGenderListQueryDto()
                .Mapping(this);
            new GetMainMenuItemListQueryDto()
              .Mapping(this);
        }


        
    }
}
