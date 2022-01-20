using AutoMapper;
using LilStoriesAPI.Models.Dtos;
using LilStoriesAPI.Models.Entities;

namespace LilStoriesAPI.Helpers
{
    public class LilStoriesApiProfile : Profile
    {
        public LilStoriesApiProfile()
        {
            CreateMap<Story, StoryDto>().ReverseMap();
            CreateMap<StoryAddDto, Story>();
            CreateMap<StoryUpdateDto, Story>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
