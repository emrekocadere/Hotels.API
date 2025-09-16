using Hotels.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Persistence;

public class HotelDbContext(DbContextOptions<HotelDbContext> options) : IdentityDbContext<User>(options)
{
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<WishList> WishLists { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

}