using System.Collections.Generic;

namespace MyAppCQRSPattern.Domain.Entities
{
    public class Gender
    {
        public Gender()
        {
            Student = new HashSet<Student>();
        }
        public int GenderId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
