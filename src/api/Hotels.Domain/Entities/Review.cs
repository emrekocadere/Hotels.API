namespace Hotels.Domain.Entities;

public class Review
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public short Rating { get; set; }
    public required string UserId { get; set; } 
    public  int HotelId { get; set; }
    
    public Hotel? Hotel { get; set; }
    public User? User { get; set; }
    
}