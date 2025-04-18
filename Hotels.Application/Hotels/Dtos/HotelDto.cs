namespace Hotels.Application.Hotels.Dtos;

public class HotelDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Star { get; set; }
    public required string ContactEmail { get; set; }
    public required string ContactNumber { get; set; }
    public AddressDto Address { get; set; }

}