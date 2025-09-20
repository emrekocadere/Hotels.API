using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;

namespace Hotels.Infrastructure.Repositories;

public class ReservationRepository:Repository<Reservation>,IReservationRepository
{
    public ReservationRepository(HotelDbContext context) : base(context)
    {
    }

    public ICollection<Reservation> GetReservationByUserId(string userId)
    {
        var reservations=_dbSet.Where(x=>x.UserId == userId).ToList();
        return reservations;
    }
}