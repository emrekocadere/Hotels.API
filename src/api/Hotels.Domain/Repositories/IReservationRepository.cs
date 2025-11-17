using Hotels.Domain.Entities;

namespace Hotels.Domain.Repositories;

public interface IReservationRepository: IRepository<Reservation>
{
    ICollection<Reservation> GetReservationByUserId(string userId);
}