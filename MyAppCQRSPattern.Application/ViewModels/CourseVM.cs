using Microsoft.AspNetCore.Mvc.Rendering;
using MyAppCQRSPattern.Application.Courses.Queries.GetCourses;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Application.ViewModels
{
    public class CourseVM
    {
        public Course CourseObj { get; set; } = new();
        public IEnumerable<GetCourseListQueryDto> CourseLists { get; set; }
        public IEnumerable<SelectListItem> CourseSelectListItemDropdown { get; set; }
    }
}
