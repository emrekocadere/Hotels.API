namespace Hotels.Domain.Entities;

public class Reservation
{
    public int Id { get; set; }
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public int RoomId { get; set; }
}