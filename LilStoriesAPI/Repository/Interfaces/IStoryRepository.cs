using LilStoriesAPI.Models.Entities;

namespace LilStoriesAPI.Repository.Interfaces
{
    public interface IStoryRepository : IBaseRepository
    {
        Task<IEnumerable<Story>> GetStoriesAsync();
        Task<Story> GetStoriesByIdAsync(int id);
    }
}
