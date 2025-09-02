using AutoMapper;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Dtos;
using Hotels.Application.Rooms.Commands.CreateRoom;

namespace Hotels.Application.Rooms.Dtos;

public class RoomsProfile:Profile
{
    public RoomsProfile()
    {
        CreateMap<CreateRoomCommand, RoomDto>();
    }
}