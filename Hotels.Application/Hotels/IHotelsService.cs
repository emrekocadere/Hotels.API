using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels;

public interface IHotelsService
{
    Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    Task<Hotel?> GetById(int id);
}