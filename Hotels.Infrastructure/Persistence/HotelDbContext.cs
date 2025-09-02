using Hotels.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Persistence;

public class HotelDbContext(DbContextOptions<HotelDbContext> options) : IdentityDbContext<User>(options)
{
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomFeature> RoomFeatures { get; set; }
}