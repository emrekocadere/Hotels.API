namespace Hotels.Domain.Entities;

public class Feature
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public ICollection<Hotel>? Hotels { get; set; }
}