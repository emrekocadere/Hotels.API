using Hotels.Application.Common;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.WishList.Commands.DeleteHotelFromWishList;

public class DeleteHotelFromWishListCommandHandler(
    IWishListRepository wishListRepository,
    IUserContext userContext)
    : IRequestHandler<DeleteHotelFromWishListCommand, Result>
{
    public async Task<Result> Handle(DeleteHotelFromWishListCommand request, CancellationToken cancellationToken)
    {
        wishListRepository.DeleteHotelFromWishList(userContext.UserId, request.HotelId);
        await wishListRepository.SaveChanges();
        return await Task.FromResult(Result.Success());
    }
}   