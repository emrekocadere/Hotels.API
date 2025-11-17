using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;

namespace Hotels.Infrastructure.Repositories;

public class WishListRepository: Repository<WishList>,IWishListRepository
{
    public WishListRepository(HotelDbContext context) : base(context) // Look at this
    {
        
    }
    public ICollection<WishList> GetWishListByUserId(string userId)
    {
       return  _dbSet.Where(x=>x.UserId==userId).ToList();
    }
    
    public void  DeleteHotelFromWishList(string userId,int hotelId)
    {
        _dbSet.Where(x=>x.UserId==userId && x.HotelId==hotelId).ToList().ForEach(x=>_dbSet.Remove(x)); // look at this
    }
}