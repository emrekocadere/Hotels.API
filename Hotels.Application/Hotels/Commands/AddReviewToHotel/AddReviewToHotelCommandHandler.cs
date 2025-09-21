using AutoMapper;
using Hotels.Application.Common;
using Hotels.Application.Hotels.Dtos;
using Hotels.Application.User;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Commands.AddReviewToHotel;

public class AddReviewToHotelCommandHandler(
    IMapper mapper,
    IReviewRepository reviewRepository,
    IUserContext userContext)
    :IRequestHandler<AddReviewToHotelCommand,Result>
   
{
    public async Task<Result> Handle(AddReviewToHotelCommand request, CancellationToken cancellationToken)
    { 
        var currentUsedId = userContext.GetCurrentUser()!.Id;
        
        var review = mapper.Map<Review>(request); 
        review.UserId = currentUsedId;
        
        await reviewRepository.Create(review);
        var affectedRows  = await  reviewRepository.SaveChanges();
        
        if (affectedRows > 0)
            return Result.Success();
        else
            return Error.DatabaseSaveError;
         
      
    }
}