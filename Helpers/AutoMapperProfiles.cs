using AutoMapper;
using SchoolApi.Dtos;
using SchoolApi.Models;

namespace SchoolApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<School, SchoolForListDto>()
                .ForMember(dest => dest.HolderName, opt => opt.MapFrom(src => src.Holder.Name));
        }
    }
}