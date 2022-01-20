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
                ? Ok(stories) : BadRequest("there are no stories");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var story = await _repository.GetStoriesByIdAsync(id);

            var storyReturn = _mapper.Map<StoryDto>(story);

            return storyReturn != null
                    ? Ok(storyReturn)
                    : BadRequest("story not find");
        }

        [HttpPost]
        public async Task<IActionResult> Post(StoryAddDto story)
        {
            if (story == null) return BadRequest("Invalid data");

            var storyAdd = _mapper.Map<Story>(story);

            _repository.Add(storyAdd);

            return await _repository.SaveChangesAsync()
                ? Ok("story added with success")
                : BadRequest("error saving story");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, StoryUpdateDto story)
        {
            if (id <= 0) return BadRequest("uninformed user");

            var storyDb = await _repository.GetStoriesByIdAsync(id);

            var storyUpdate = _mapper.Map(story, storyDb);

            _repository.Update(storyUpdate);

            return await _repository.SaveChangesAsync()
                ? Ok("story updated with success")
                : BadRequest("error updating story");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("invalid story");

            var storyDelete = await _repository.GetStoriesByIdAsync(id);

            if (storyDelete == null) return NotFound("story not found");

            _repository.Delete(storyDelete);

            return await _repository.SaveChangesAsync()
                 ? Ok("story deleted with success")
                 : BadRequest("error deleting story");
        }
    }
}
