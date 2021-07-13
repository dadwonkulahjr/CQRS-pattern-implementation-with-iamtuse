using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAppCQRSPattern.Domain.Entities
{
    public class Course
    {
        public Course()
        {
            MainMenuItem = new HashSet<MainMenuItem>();
        }
        public int CourseId { get; set; }
        [Display(Name = "Course name"), Required]
        public string CourseName { get; set; }
        [Display(Name = "Course number"), Required]
        public int? CourseNumber { get; set; }
        [Display(Name = "Course hour"), Required]
        public int? CreditHour { get; set; }
        public ICollection<MainMenuItem> MainMenuItem { get; set; }

    }
}
