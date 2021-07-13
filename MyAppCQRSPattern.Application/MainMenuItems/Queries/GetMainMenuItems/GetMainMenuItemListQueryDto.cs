using AutoMapper;
using MyAppCQRSPattern.Application.Common.Mappings;
using MyAppCQRSPattern.Domain.Entities;


namespace MyAppCQRSPattern.Application.MainMenuItems.Queries.GetMainMenuItems
{
    public class GetMainMenuItemListQueryDto : IMapFrom<MainMenuItem>
    {
        public int MainMenuId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string StudentDescription { get; set; }
        public string GenderDescription { get; set; }
        public string CourseDescripion { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MainMenuItem, GetMainMenuItemListQueryDto>();
        }
    }
}
