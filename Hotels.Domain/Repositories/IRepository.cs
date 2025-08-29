namespace Hotels.Domain.Repositories;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task Create(T entity);
    Task Delete(T entity);
    Task<int> SaveChanges();
}