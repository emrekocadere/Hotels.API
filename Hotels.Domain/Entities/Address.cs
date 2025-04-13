using System.Globalization;

namespace Hotels.Domain.Entities;

public class Address
{
    public required string City { get; set; }
    public required string Country { get; set; }
    public required string PostalCode { get; set; }
}