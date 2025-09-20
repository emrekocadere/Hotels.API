using Hotels.Application.Reservation.Commands.CreateReservation;
using Hotels.Application.Reservation.Queries.GetReservation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[ApiController]
public class ReservationController(IMediator mediator):ControllerBase   
{
    [HttpPost("reservations")]
    public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
    {
        var result = await mediator.Send(command);
        
        return Ok(result);
    }
    
    [HttpGet("reservations")]
    public async Task<IActionResult> GetReservations()
    {
        var result = await mediator.Send(new GetReservationQuery());
        
        return Ok(result);
    }
    
}