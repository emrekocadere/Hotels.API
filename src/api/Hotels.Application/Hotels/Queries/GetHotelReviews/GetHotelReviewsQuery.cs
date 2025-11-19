using System;
using Hotels.Application.Hotels.Dtos;
using Hotels.Domain.Entities;
using MediatR;

namespace Hotels.Application.Hotels.Queries.GetHotelReviews;

public record GetHotelReviewsQuery(int HotelId):IRequest<IList<ReviewDto>>;

