using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;
using Hotels.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;


namespace Hotels.Infrastructure.Extensions;

public static class ServiceCollectionsExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("HotelsDb");
        services.AddDbContext<HotelDbContext>(options => options.UseSqlServer(connectionString));
        services.AddIdentityApiEndpoints<User>()
            .AddEntityFrameworkStores<HotelDbContext>();      
        services.AddScoped<IRepository<Hotel>, Repository<Hotel>>();
        services.AddScoped<IRepository<Room>, Repository<Room>>();
        services.AddScoped<IRepository<WishList>, Repository<WishList>>();
        services.AddScoped<IWishListRepository, WishListRepository>();
        services.AddScoped<IReservationRepository, ReservationRepository>();
        services.AddScoped<IRepository<Domain.Entities.Reservation>, Repository<Domain.Entities.Reservation>>();
    }
}