namespace Hotels.Domain.Entities;

public class Hotel
{
    public int Id { get; set; }
    public  string Name { get; set; }
    public short StarRating { get; set; }
    public  string ContactEmail { get; set; }
    public  string ContactNumber { get; set; }
    public  int CityId { get; set; }
    public TimeOnly CheckInTime { get; set; }
    public TimeOnly CheckOutTime { get; set; }
    
    public City? City { get; set; }
    public ICollection<Feature>? Features { get; set; }
    public ICollection<Room>? Rooms { get; set; }
}