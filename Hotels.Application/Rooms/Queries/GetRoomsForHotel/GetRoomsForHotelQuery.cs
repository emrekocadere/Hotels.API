using Hotels.Application.Rooms.Dtos;
using MediatR;

namespace Hotels.Application.Rooms.Queries.GetRoomsForHotel;

public class GetRoomsForHotelQuery(int hotelId):IRequest<IEnumerable<RoomDto>>
{
    public int HotelId { get; } = hotelId;
}