using AutoMapper;
using Income.Models;

namespace Income.DataTransferObjects.MappingEngine
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Skill, SkillModel>(MemberList.None).ReverseMap();
        }
    }
}
