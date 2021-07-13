using AutoMapper;
using MyAppCQRSPattern.Application.Common.Mappings;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Application.Genders.Queries.GetGenders
{
    public class GetGenderListQueryDto : IMapFrom<Gender>
    {

        public int GenderId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Student { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Gender, GetGenderListQueryDto>();
        }
    }
}
