using AutoMapper;
using MyAppCQRSPattern.Application.Common.Mappings;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Application.Courses.Queries.GetCourses
{
    public class GetCourseListQueryDto : IMapFrom<Course>
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseNumber { get; set; }
        public int CreditHour { get; set; }
        public ICollection<MainMenuItem> MainMenuItem { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Course, GetCourseListQueryDto>();
        }
    }
}
