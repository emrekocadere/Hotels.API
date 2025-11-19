using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Repositories;

public class ReviewRepository:Repository<Review>,IReviewRepository
{
    public ReviewRepository(HotelDbContext context) : base(context)
    {
    }

    public IList<Review> GetReviewsByHotelId(int hotelId)
    {
       var reviews= _dbSet.AsNoTracking().Where(x=>x.HotelId==hotelId).ToList();
       return reviews;
    }
}