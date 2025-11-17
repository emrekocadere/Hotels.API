using Hotels.Application.Common;
using Hotels.Application.WishList.Dtos;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Hotels.Application.WishList.Queries.GetWishlist;

public class GetWishListQuery:IRequest<ResultT<WishListDto>>
{
    
}