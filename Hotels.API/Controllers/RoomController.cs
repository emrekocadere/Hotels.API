using Hotels.Application.Rooms.Commands.CreateRoom;
using Hotels.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[Route("api/hotels/{hotelId}/rooms")]
public class RoomController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateRoom([FromRoute] int hotelId, CreateRoomCommand command)
    {
        await mediator.Send(command);
        return Created();
    }
}