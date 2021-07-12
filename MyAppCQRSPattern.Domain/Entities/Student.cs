using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAppCQRSPattern.Domain.Entities
{
    public class Student
    {
        public Student()
        {
            MainMenuItem = new HashSet<MainMenuItem>();
        }
        public int StudentId { get; set; }
        [Display(Name ="Firstname"), Required]
        public string FirstName { get; set; }
        [Display(Name ="Lastname"), Required]
        public string LastName { get; set; }
        [Display(Name ="Date Enrolled"), Required]
        public DateTime? DateEnrolled { get; set; }
        [Display(Name ="Student Email Address"), Required]
        public string Email { get; set; }
        [Display(Name ="Fullname")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        [Display(Name ="Gender")]
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }

        public ICollection<MainMenuItem> MainMenuItem { get; set; }

    }
}
