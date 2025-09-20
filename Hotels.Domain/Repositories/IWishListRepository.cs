using Hotels.Domain.Entities;

namespace Hotels.Domain.Repositories;

public interface IWishListRepository: IRepository<WishList>
{
    ICollection<WishList> GetWishListByUserId(string userId);
}