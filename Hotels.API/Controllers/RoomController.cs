using Hotels.Application.Rooms.Commands.CreateRoom;
using Hotels.Application.Rooms.Queries.GetRoomByIdForHotel;
using Hotels.Application.Rooms.Queries.GetRoomsForHotel;
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
    
    [HttpGet]
    public async Task<IActionResult> CreateRoom([FromRoute] int hotelId)
    {
        var rooms=await mediator.Send(new GetRoomsForHotelQuery(hotelId));
        return Created();
    }
    [HttpGet("{roomId}")]
    public async Task<IActionResult> CreateRoom([FromRoute] int hotelId,[FromRoute] int roomId)
    {
        var rooms=await mediator.Send(new GetRoomByIdForHotelQuery(hotelId,roomId));
        return Created();
    }

}