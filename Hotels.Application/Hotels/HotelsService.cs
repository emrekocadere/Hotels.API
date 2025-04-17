using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;

namespace Hotels.Application.Hotels;

public class HotelsService(IHotelsRepository hotelsRepository) : IHotelsService
{
    public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        var hotels = await hotelsRepository.GetAllAsync();
        return hotels;
    }

}