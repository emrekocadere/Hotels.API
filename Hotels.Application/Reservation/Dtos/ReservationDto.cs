using Hotels.Application.Hotels.Dtos;
using Hotels.Application.Rooms.Dtos;

namespace Hotels.Application.Reservation.Dtos;

public class ReservationDto
{
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public required RoomDto Room { get; set; }
    public required HotelDto HotelDetail { get; set; }
}