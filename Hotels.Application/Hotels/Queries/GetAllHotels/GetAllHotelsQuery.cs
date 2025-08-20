using Hotels.Application.Hotels.Dtos;
using MediatR;

namespace Hotels.Application.Hotels.Queries.GetAllHotels;

public class GetAllHotelsQuery:IRequest<IEnumerable<HotelDto>>
{
    
}