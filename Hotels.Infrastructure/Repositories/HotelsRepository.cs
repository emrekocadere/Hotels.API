using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Repositories;

public class HotelsRepository(HotelDbContext dbContext): IHotelsRepository
{
    public async Task<IEnumerable<Hotel>> GetAllAsync()
    {
        var hotels = await dbContext.Hotels.Include(h=>h.Address).ToListAsync();
        return hotels;
    }

    public async Task<Hotel?> GetByIdAsync(int id)
    {
        var hotel = await dbContext.Hotels.Include(h=>h.Rooms).FirstOrDefaultAsync(h=>h.Id == id);
        return hotel;
    }
}