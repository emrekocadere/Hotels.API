using Hotels.Application.Common;
using MediatR;

namespace Hotels.Application.Hotels.Commands.AddReviewToHotel;

public class AddReviewToHotelCommand:IRequest<Result>
{
    public string Content { get; set; }
    public int HotelId { get; set; }
    public short Rating { get; set; }
}