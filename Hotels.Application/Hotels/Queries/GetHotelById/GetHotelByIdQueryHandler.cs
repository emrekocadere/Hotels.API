using AutoMapper;
using Hotels.Application.Hotels.Dtos;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Queries.GetHotelById;

public class GetHotelByIdQueryHandler(IMapper mapper, IHotelsRepository hotelsRepository):IRequestHandler<GetHotelByIdQuery,HotelDto?>
{
    public async Task<HotelDto?> Handle(GetHotelByIdQuery request, CancellationToken cancellationToken)
    {
        var hotel = await hotelsRepository.GetByIdAsync(request.Id);
        var hotelsDtos=mapper.Map<HotelDto>(hotel);
        return hotelsDtos;
    }
}