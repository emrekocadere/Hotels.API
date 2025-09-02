namespace Hotels.Domain.Entities;

public class RoomFeature
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public ICollection<Room>? Room { get; set; }
}