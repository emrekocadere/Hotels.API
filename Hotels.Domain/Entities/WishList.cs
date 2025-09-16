namespace Hotels.Domain.Entities;

public class WishList
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public int HotelId { get; set; }
    
    public User? User { get; set; }
    public Hotel? Hotel { get; set; }
}