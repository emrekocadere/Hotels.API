using Hotels.Domain.Entities;

namespace Hotels.Domain.Repositories;

public interface IHotelsRepository
{
    Task<IEnumerable<Hotel>> GetAllAsync();
}