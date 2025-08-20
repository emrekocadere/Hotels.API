using AutoMapper;
using Hotels.Application.Hotels.Dtos;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Queries.GetAllHotels;

public class GetAllHotelsQueryHandler(IHotelsRepository hotelsRepository,IMapper mapper):IRequestHandler<GetAllHotelsQuery,IEnumerable<HotelDto>>
{
    public async Task<IEnumerable<HotelDto>> Handle(GetAllHotelsQuery request, CancellationToken cancellationToken)
    {
        var hotels = await hotelsRepository.GetAllAsync();
        var hotelsDtos=mapper.Map<IEnumerable<HotelDto>>(hotels);
        return hotelsDtos;
    }
} 