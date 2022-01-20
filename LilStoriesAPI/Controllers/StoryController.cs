using AutoMapper;
using LilStoriesAPI.Models.Dtos;
using LilStoriesAPI.Models.Entities;
using LilStoriesAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LilStoriesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoryController : ControllerBase
    {
        private readonly IStoryRepository _repository;
        private readonly IMapper _mapper;

        public StoryController(IStoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stories = await _repository.GetStoriesAsync();

            return stories.Any()
                ? Ok(stories) : BadRequest("There are no stories");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var story = await _repository.GetStoriesByIdAsync(id);

            var storyReturn = _mapper.Map<StoryDto>(story);

            return storyReturn != null
                    ? Ok(storyReturn)
                    : BadRequest("Story not find");
        }

        [HttpPost]
        public async Task<IActionResult> Post(StoryAddDto story)
        {
            if (story == null) return BadRequest("Invalid data");

            var storyAdd = _mapper.Map<Story>(story);

            _repository.Add(storyAdd);

            return await _repository.SaveChangesAsync()
                ? Ok("Story added with success")
                : BadRequest("Error saving story");
        }
    }
}
