namespace Hotels.Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public short Rating { get; set; }
    public required string UserId { get; set; } 
    public required string HotelId { get; set; }
    
    public Hotel? Hotel { get; set; }
    public User? User { get; set; }
    
}