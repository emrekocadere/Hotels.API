using Hotels.Application.Common;
using MediatR;

namespace Hotels.Application.WishList.Commands.AddHotelToWishList;

public class AddHotelToWishListCommand:IRequest<Result>
{
    public int HotelId { get; set; }
} 