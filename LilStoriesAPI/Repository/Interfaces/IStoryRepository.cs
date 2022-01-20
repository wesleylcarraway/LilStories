using LilStoriesAPI.Models.Dtos;
using LilStoriesAPI.Models.Entities;

namespace LilStoriesAPI.Repository.Interfaces
{
    public interface IStoryRepository : IBaseRepository
    {
        Task<IEnumerable<StoryDto>> GetStoriesAsync();
        Task<Story> GetStoriesByIdAsync(int id);
    }
}
