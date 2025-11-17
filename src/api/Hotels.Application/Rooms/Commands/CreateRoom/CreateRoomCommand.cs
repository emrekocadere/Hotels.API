using Hotels.Domain.Entities;
using MediatR;

namespace Hotels.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommand : IRequest
{
    public int HotelId { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
}