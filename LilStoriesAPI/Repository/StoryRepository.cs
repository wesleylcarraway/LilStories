using LilStoriesAPI.Context;
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

        public async Task<IEnumerable<Story>> GetStoriesAsync()
        {
            var stories = await _context.Stories.ToListAsync();
            return stories;
        }

        public async Task<Story> GetStoriesByIdAsync(int id)
        {
            var story = await _context.Stories.SingleOrDefaultAsync(st => st.Id == id);
            return story;
        }
    }
}
