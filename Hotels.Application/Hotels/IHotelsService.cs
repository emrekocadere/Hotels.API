using Hotels.Application.Hotels.Dtos;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels;

public interface IHotelsService
{
    Task<IEnumerable<HotelDto>> GetAllHotelsAsync();
    // Task<HotelDto?> GetById(int id);
}