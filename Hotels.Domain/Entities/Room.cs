namespace Hotels.Domain.Entities;

public class Room
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
    public int HotelId { get; set; }

    public ICollection<Feature>? Features { get; set; }
    public Hotel? Hotel { get; set; }
    
}