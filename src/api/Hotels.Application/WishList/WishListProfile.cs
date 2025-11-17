using AutoMapper;
using Hotels.Application.WishList.Commands.AddHotelToWishList;
using Hotels.Application.WishList.Dtos;

namespace Hotels.Application.WishList;

public class WishListProfile:Profile
{
    public WishListProfile()
    {
        CreateMap<AddHotelToWishListCommand, Domain.Entities.WishList>();
      
    }
}