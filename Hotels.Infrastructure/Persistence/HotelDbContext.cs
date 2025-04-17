using Hotels.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Persistence;

public class HotelDbContext(DbContextOptions<HotelDbContext> options) : DbContext(options)
{
    internal DbSet<Hotel> Hotels { get; set; }
    internal DbSet<Room> Rooms { get; set; }
    internal DbSet<Address> Address { get; set; }
    internal DbSet<Reservation> Reservations { get; set; }
    
}