using LilStoriesAPI.Context;
using LilStoriesAPI.Models.Dtos;
using LilStoriesAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LilStoriesAPI.Repository.Interfaces
{
    public class StoryRepository : BaseRepository, IStoryRepository
    {
        private readonly LilStoriesApiContext _context;
        public StoryRepository(LilStoriesApiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StoryDto>> GetStoriesAsync()
        {
            var stories = await _context.Stories
                .Select(x => new StoryDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Genre = x.Genre,
                    Author = x.Author,
                    Content = x.Content
                })
                .ToListAsync();

            return stories;
        }

        public async Task<Story> GetStoriesByIdAsync(int id)
        {
            var story = await _context.Stories.Where(x => x.Id == id).FirstOrDefaultAsync();
            //SingleOrDefaultAsync(st => st.Id == id);
            return story;
        }
    }
}
