using Hotels.Application.Hotels;
using Hotels.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelsController(IHotelsService hotelsService):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
       var hotels= await hotelsService.GetAllHotelsAsync();
       return Ok(hotels);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAll(int id)
    {
        var hotels= await hotelsService.GetById(id);
        if(hotels is null)
            return NotFound();
        
        return Ok(hotels);
    }
}