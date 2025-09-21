using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Repositories;

public class ReservationRepository:Repository<Reservation>,IReservationRepository
{
    public ReservationRepository(HotelDbContext context) : base(context)
    {
    }

    public ICollection<Reservation> GetReservationByUserId(string userId)
    {
        var reservations=_dbSet.AsNoTracking()
            .Where(x=>x.UserId == userId)
            .Include(x=>x.Room)
            .ThenInclude(x=>x.Hotel)
            .ToList();
        return reservations;
    }
}