using MediatR;

namespace Hotels.Application.Hotels.Commands.UpdateHotel;

public class UpdateHotelCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public short StarRating { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactNumber { get; set; }
    public int CityId { get; set; }
    public TimeOnly CheckInTime { get; set; }
    public TimeOnly CheckOutTime { get; set; }
}