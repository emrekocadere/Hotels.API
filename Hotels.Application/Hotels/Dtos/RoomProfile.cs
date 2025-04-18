using AutoMapper;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class RoomProfile:Profile
{
    public RoomProfile()
    {
        CreateMap<Room,RoomDto>();
    }
}