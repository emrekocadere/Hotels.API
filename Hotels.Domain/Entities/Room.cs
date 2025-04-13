namespace Hotels.Domain.Entities;

public class Room
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public int RoomNumber { get; set; }
    public Hotel Hotel { get; set; } = default!;
    
}