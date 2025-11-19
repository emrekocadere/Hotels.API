using System;
using AutoMapper;
using Hotels.Application.Hotels.Dtos;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Queries.GetHotelReviews;

public class GetHotelReviewsQueryHandler (IMapper mapper,
IReviewRepository  reviewRepository)
: IRequestHandler<GetHotelReviewsQuery, IList<ReviewDto>>
{
    public Task<IList<ReviewDto>> Handle(GetHotelReviewsQuery request, CancellationToken cancellationToken)
    {
        var reviews = reviewRepository.GetReviewsByHotelId(request.HotelId);
        var reviewDtos = mapper.Map<IList<ReviewDto>>(reviews);
        return Task.FromResult(reviewDtos);
    }
}
