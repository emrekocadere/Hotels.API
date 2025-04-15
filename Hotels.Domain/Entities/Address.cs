using System.Globalization;

namespace Hotels.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public required string PostalCode { get; set; }
    public Hotel? Hotel { get; set; }
}