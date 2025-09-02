using AutoMapper;
using Hotels.Application.Rooms.Dtos;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Rooms.Queries.GetRoomByIdForHotel;

public class GetRoomByIdForHotelQueryHandler(IRepository<Hotel>hotelRepository,IMapper mapper):IRequestHandler<GetRoomByIdForHotelQuery,RoomDto>
{
    public async Task<RoomDto> Handle(GetRoomByIdForHotelQuery request, CancellationToken cancellationToken)
    {
        var hotel = await hotelRepository.GetByIdAsync(request.HotelId);
        var room= hotel.Rooms.FirstOrDefault(r=>r.Id == request.RoomId);
        var roomDto=mapper.Map<RoomDto>(room);
        return roomDto;
    }
}