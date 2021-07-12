using Microsoft.AspNetCore.Mvc.Rendering;
using MyAppCQRSPattern.Application.Students.Queries.GetStudents;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Application.ViewModels
{
    public class StudentVM
    {
        public Student StudentObj { get; set; } = new();
        public IEnumerable<GetStudentListQueryDto> StudentLists { get; set; }
        public IEnumerable<SelectListItem> StudentSelectListItemDropdown { get; set; }
    }
}
