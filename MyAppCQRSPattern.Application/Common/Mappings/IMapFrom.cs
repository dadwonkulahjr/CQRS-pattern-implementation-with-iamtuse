using AutoMapper;

namespace MyAppCQRSPattern.Application.Common.Mappings
{
    public interface IMapFrom<TEntity>
    {
        void Mapping(Profile profile);
         
    }
}
