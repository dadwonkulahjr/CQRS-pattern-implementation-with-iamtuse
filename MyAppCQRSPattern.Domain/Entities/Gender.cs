using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAppCQRSPattern.Domain.Entities
{
    public class Gender
    {
        public Gender()
        {
            Student = new HashSet<Student>();
        }
        public int GenderId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
