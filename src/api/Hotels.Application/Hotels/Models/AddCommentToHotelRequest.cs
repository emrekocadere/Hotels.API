namespace Hotels.Application.Hotels.Models;

public class AddCommentToHotelRequest
{
    public string Content { get; set; }
    public short RatingStar { get; set; }
    public int HotelId { get; set; }
}