using LilStoriesAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LilStoriesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoryController : ControllerBase
    {
        private readonly IStoryRepository _repository;

        public StoryController(IStoryRepository repository)
        {
            _repository = repository;
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

            return story != null
                    ? Ok(story)
                    : BadRequest("Story not find");
        }
    }
}
