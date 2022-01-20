﻿using AutoMapper;
using LilStoriesAPI.Models.Dtos;
using LilStoriesAPI.Models.Entities;

namespace LilStoriesAPI.Helpers
{
    public class LilStoriesApiProfile : Profile
    {
        public LilStoriesApiProfile()
        {
            CreateMap<Story, StoryDto>();
            CreateMap<StoryAddDto, Story>();
        }
    }
}
