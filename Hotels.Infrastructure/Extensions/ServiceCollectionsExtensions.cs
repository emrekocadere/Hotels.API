using Hotels.Domain.Repositories;
using Hotels.Infrastructure.Persistence;
using Hotels.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Infrastructure.Extensions;

public static class ServiceCollectionsExtensions
{
    public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("HotelsDb");
        services.AddDbContext<HotelDbContext>(options=> options.UseSqlServer(connectionString));
        services.AddScoped<IHotelsRepository, HotelsRepository>();
    }
}