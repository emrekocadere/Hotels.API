namespace Hotels.Application.Reservation.Dtos;

public class ReservationDto
{
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public int RoomId { get; set; }
}