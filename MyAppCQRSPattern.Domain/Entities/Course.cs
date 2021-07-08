using System.Collections;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Domain.Entities
{
    public class Course
    {
        public Course()
        {
            MainMenuItem = new HashSet<MainMenuItem>();
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseNumber { get; set; }
        public int CreditHour { get; set; }
        public ICollection<MainMenuItem> MainMenuItem { get; set; }

    }
}
