using AutoMapper;
using Hotels.Application.Rooms.Dtos;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Rooms.Queries.GetRoomsForHotel;

public class GetRoomsForHoteltQueryHandler(IRepository<Hotel> hotelRepository,IMapper mapper):IRequestHandler<GetRoomsForHotelQuery,IEnumerable<RoomDto>>
{
    public async Task<IEnumerable<RoomDto>> Handle(GetRoomsForHotelQuery request, CancellationToken cancellationToken)
    {
        var hotel = await hotelRepository.GetByIdAsync(request.HotelId);
        var roomDtos= mapper.Map<IEnumerable<RoomDto>>(hotel.Rooms);
        return roomDtos;



    }
}