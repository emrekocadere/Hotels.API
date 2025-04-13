namespace Hotels.Domain.Entities;

public class Hotel
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Star { get; set; }
    public required string ContactEmail { get; set; }
    public required string ContactNumber { get; set; }
    
    public Address Address { get; set; }
    
    

}

