namespace Hotels.Application.Hotels.Dtos;

public class CreateHotelDto
{
    public required string Name { get; set; }
    public required string Star { get; set; }
    public required string ContactEmail { get; set; }
    public required string ContactNumber { get; set; }
    
    public required string City { get; set; }
    public required string Country { get; set; }
    public required string PostalCode { get; set; }
}