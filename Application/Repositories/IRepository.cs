
namespace Application.Repositories;

public  interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task<T?> GetByIdAsync(int id);
}
