using Hotels.Application.WishList.Commands.AddHotelToWishList;
using Hotels.Application.WishList.Commands.DeleteHotelFromWishList;
using Hotels.Application.WishList.Queries.GetWishlist;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[ApiController]
public class WishListController(IMediator mediator):ControllerBase
{
    [HttpPost("wishlist/hotels/{hotelId}")]
    public async Task<ActionResult> AddHotelToWishList(int hotelId)
    {
        var result=await mediator.Send(new AddHotelToWishListCommand{HotelId=hotelId});
        
        return StatusCode(201);
    }
    
    [HttpGet("wishlist")]
    public async Task<ActionResult> GetWishList()
    {
        var result=await mediator.Send(new GetWishListQuery());
        
        return Ok(result);
    }
    
    [HttpDelete("wishlist/hotels/{hotelId}")]
    public async Task<ActionResult> DeleteHotelFromWishList(int hotelId)
    {
        var result=await mediator.Send(new DeleteHotelFromWishListCommand(hotelId));
        
        return Ok(result);
    }
}