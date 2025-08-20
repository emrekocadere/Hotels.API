using FluentValidation;
using Hotels.Application.Hotels;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Dtos;
using Hotels.Application.Hotels.Queries.GetAllHotels;
using Hotels.Application.Hotels.Queries.GetHotelById;
using Hotels.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelsController(IMediator mediator):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var hotels = await mediator.Send(new GetAllHotelsQuery());
       return Ok(hotels);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var hotels = await mediator.Send(new GetHotelByIdQuery(id));
        if(hotels is null)
            return NotFound();
        
        return Ok(hotels);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateHotel(CreateHotelCommand command)
    {
       // var a = _validator.Validate(createHotelDto);
        
         int id=await mediator.Send(command);
        // return CreatedAtAction(nameof(GetById), new { id }, null);
        return Ok();
    }   
}