using LilStoriesAPI.Context;
using LilStoriesAPI.Repository.Interfaces;

namespace LilStoriesAPI.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly LilStoriesApiContext _context;
        public BaseRepository(LilStoriesApiContext context)
        {
            _context = context; 
        }

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
