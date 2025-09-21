using Microsoft.AspNetCore.Identity;

namespace Hotels.Domain.Entities;

public class User:IdentityUser
{
    public DateOnly RegisteredOn { get; set; }
    
    public ICollection<Review>? Comments { get; set; }
    public ICollection<Reservation>? Reservations { get; set; }
    public ICollection<WishList>? WishList { get; set; }
}