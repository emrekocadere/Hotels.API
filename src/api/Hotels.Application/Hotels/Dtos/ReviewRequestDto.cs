using System;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class ReviewRequestDto
{
    public required string Content { get; set; }
    public short Rating { get; set; }
    
}
