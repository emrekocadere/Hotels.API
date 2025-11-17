using Hotels.Application.Rooms.Dtos;
using MediatR;

namespace Hotels.Application.Rooms.Queries.GetRoomByIdForHotel;

public class GetRoomByIdForHotelQuery(int hotelId,int roomId):IRequest<RoomDto>
{
    public int HotelId { get; } = hotelId;
    public int RoomId { get; } = roomId;
}