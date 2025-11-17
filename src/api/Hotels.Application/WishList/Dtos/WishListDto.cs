using System.Collections;

namespace Hotels.Application.WishList.Dtos;

public class WishListDto
{
    public ICollection<int>? HotelIds { get; set; }
}