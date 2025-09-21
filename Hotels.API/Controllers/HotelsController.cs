using FluentValidation;
using Hotels.Application.Hotels;
using Hotels.Application.Hotels.Commands.AddReviewToHotel;
using Hotels.Application.Hotels.Commands.AddReviewToHotel;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Commands.DeleteHotel;
using Hotels.Application.Hotels.Commands.UpdateHotel;
using Hotels.Application.Hotels.Dtos;
using Hotels.Application.Hotels.Models;
using Hotels.Application.Hotels.Queries.GetAllHotels;
using Hotels.Application.Hotels.Queries.GetHotelById;
using Hotels.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<HotelDto>> GetAll()
    {
        var hotels = await mediator.Send(new GetAllHotelsQuery());
        return Ok(hotels);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var hotels = await mediator.Send(new GetHotelByIdQuery(id));
        if (hotels is null)
            return NotFound();

        return Ok(hotels);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateHotel(int id, UpdateHotelCommand command)
    {
        command.Id = id;
        var isUpdated = await mediator.Send(command);
        if (isUpdated)
            return NoContent();

        return NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotel(int id)
    {
        var isDeleted = await mediator.Send(new DeleteHotelCommand(id));
        if (isDeleted)
            return NoContent();

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> CreateHotel(CreateHotelCommand command)
    {
        // var a = _validator.Validate(createHotelDto);

        int id = await mediator.Send(command);
        // return CreatedAtAction(nameof(GetById), new { id }, null);
        return Ok();
    }
    
    [HttpPost("{hotelId}/reviews")]
    public async Task<IActionResult> AddReviewToHotel(int hotelId,AddCommentToHotelRequest commentDto)
    {
     

        var id = await mediator.Send(new AddReviewToHotelCommand()
        {
            HotelId = hotelId,
            Content = commentDto.Content,
            Rating= commentDto.RatingStar
            
        });
        // return CreatedAtAction(nameof(GetById), new { id }, null);
        return Ok(id);
    }
}