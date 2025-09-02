namespace Hotels.Application.Hotels.Dtos;

public class HotelDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required short StarRating { get; set; }
    public required string ContactEmail { get; set; }
    public required string ContactNumber { get; set; }
    public required int AddressId { get; set; }
    public TimeOnly CheckInTime { get; set; }
    public TimeOnly CheckOutTime { get; set; }
}