using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly BetDbContext _dbContext;

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task PostAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public async Task RemoveAsync(T entity)
        {
            await Task.Run(() => _dbContext.Set<T>().Remove(entity));
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _dbContext.Set<T>().Update(entity));
        }
    }
}
