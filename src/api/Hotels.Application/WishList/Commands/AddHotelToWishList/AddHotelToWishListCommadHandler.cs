using AutoMapper;
using Hotels.Application.Common;

using Hotels.Domain.Repositories;
using MediatR;
using IUserContext = Hotels.Application.Common.IUserContext;

namespace Hotels.Application.WishList.Commands.AddHotelToWishList;

public class AddHotelToWishListCommadHandler(
    IRepository<Domain.Entities.WishList> wishListRepository,
    IMapper mapper,
    IUserContext userContext)
    :IRequestHandler<AddHotelToWishListCommand,Result>
{
    public async Task<Result> Handle(AddHotelToWishListCommand request, CancellationToken cancellationToken)
    {
        var wishList = mapper.Map<Domain.Entities.WishList>(request);
        wishList.UserId = userContext.UserId;
        
       await wishListRepository.Create(wishList);
        
        var affectedRows= await wishListRepository.SaveChanges();
        if (affectedRows > 0)
            return Result.Success();
        else
            return Error.DatabaseSaveError;
    }
    
}