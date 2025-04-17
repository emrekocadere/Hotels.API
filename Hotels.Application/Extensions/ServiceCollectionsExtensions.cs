using Hotels.Application.Hotels;
using Hotels.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Application.Extensions;

public static class ServiceCollectionsExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IHotelsService, HotelsService>();
    }
}