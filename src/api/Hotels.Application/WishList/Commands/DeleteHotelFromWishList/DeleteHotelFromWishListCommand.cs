using Hotels.Application.Common;
using MediatR;

namespace Hotels.Application.WishList.Commands.DeleteHotelFromWishList;

public record DeleteHotelFromWishListCommand(int HotelId):IRequest<Result>;