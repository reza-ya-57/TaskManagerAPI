using AutoMapper;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Web.Dtos.BaseDto;

namespace TaskManagerAPI.Web.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonRequest, Person>();
        }
    }
}
