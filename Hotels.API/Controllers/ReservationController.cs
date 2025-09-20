using Hotels.Application.Reservation.Commands.CreateReservation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[ApiController]
public class ReservationController(IMediator mediator):ControllerBase   
{
    [HttpPost("Reservation")]
    public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
    {
        var result = await mediator.Send(command);
        
        return Ok(result);
    }
    
}