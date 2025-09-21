using Hotels.Domain.Entities;

namespace Hotels.Domain.Repositories;

public interface IReviewRepository:IRepository<Review>
{
     IList<Review> GetReviewsByHotelId(int hotelId);
}