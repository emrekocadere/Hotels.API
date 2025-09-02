using AutoMapper;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Dtos;
using Hotels.Application.Rooms.Commands.CreateRoom;
using Hotels.Domain.Entities;

namespace Hotels.Application.Rooms.Dtos;

public class RoomsProfile:Profile
{
    public RoomsProfile()
    {
        CreateMap<CreateRoomCommand, Room>();
    }
}