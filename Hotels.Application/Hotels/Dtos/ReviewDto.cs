using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class ReviewDto
{
    public required string Content { get; set; }
    public short Rating { get; set; }
    public Hotel? Hotel { get; set; }
    
}