namespace DataAccess
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task PostAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
