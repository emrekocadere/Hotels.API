using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class HotelWithRoomsDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Star { get; set; }
    public required string ContactEmail { get; set; }
    public required string ContactNumber { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public required string PostalCode { get; set; }
    
    public required ICollection<RoomDto>Rooms { get; set; }
}