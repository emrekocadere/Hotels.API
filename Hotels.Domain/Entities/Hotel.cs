namespace Hotels.Domain.Entities;

public class Hotel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Star { get; set; }
    public required string ContactEmail { get; set; }
    public required string ContactNumber { get; set; }
    public required int AddressId { get; set; }
    
    public Address? Address { get; set; }
    public ICollection<Room>? Rooms{ get; set; }

    
    

}

