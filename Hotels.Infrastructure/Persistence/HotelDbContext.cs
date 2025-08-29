using Hotels.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Persistence;

public class HotelDbContext(DbContextOptions<HotelDbContext> options) : DbContext(options)
{
    internal DbSet<City> Cities { get; set; }
    internal DbSet<Country> Countries { get; set; }
    internal DbSet<Hotel> Hotels { get; set; }
    internal DbSet<Feature> Features { get; set; }

    internal DbSet<Room> Rooms { get; set; }
    internal DbSet<RoomFeature> RoomFeatures { get; set; }
}