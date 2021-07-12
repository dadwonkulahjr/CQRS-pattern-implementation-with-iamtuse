using AutoMapper;
using MyAppCQRSPattern.Application.Common.Mappings;
using MyAppCQRSPattern.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MyAppCQRSPattern.Application.Students.Queries.GetStudents
{
    public class GetStudentListQueryDto : IMapFrom<Student>
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateEnrolled { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }
        public string FullName
        {
            private set {; }
            get { return FirstName + " " + LastName; }
        }
        public virtual Gender Gender { get; set; }

        //public static Expression<Func<Student, GetStudentListQueryDto>> Projection
        //{
        //    get
        //    {
        //        return list => new GetStudentListQueryDto
        //        {
        //            StudentId = list.StudentId,
        //            FirstName = list.FirstName,
        //            LastName = list.LastName,
        //            Email = list.Email,
        //            DateEnrolled = list.DateEnrolled,
        //            GenderId = list.GenderId,
        //            Gender = list.Gender,
        //            FullName = list.FullName

        //        };
        //    }
        //}

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Student, GetStudentListQueryDto>();
        }
    }
}
