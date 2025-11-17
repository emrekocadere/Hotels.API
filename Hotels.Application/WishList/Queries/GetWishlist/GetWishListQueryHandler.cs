using AutoMapper;
using Hotels.Application.Common;
using Hotels.Application.WishList.Dtos;
using Hotels.Domain.Repositories;
using MediatR;
using IUserContext = Hotels.Application.Common.IUserContext;

namespace Hotels.Application.WishList.Queries.GetWishlist;

public class GetWishListQueryHandler(
    IWishListRepository wishListRepository,
    IUserContext userContext,
    IMapper mapper)
    :IRequestHandler<GetWishListQuery,ResultT<WishListDto>>
{
    public async Task<ResultT<WishListDto>> Handle(GetWishListQuery request, CancellationToken cancellationToken) // look ath 
    {
        string currentUserId = userContext.UserId;
        var wishList=wishListRepository.GetWishListByUserId(currentUserId);
        WishListDto wishListDto = new()
        {
            HotelIds = new List<int>()
        };
        foreach (var wish in wishList)
        {
            wishListDto.HotelIds.Add(wish.HotelId);
        }

        return wishListDto;
    }
}