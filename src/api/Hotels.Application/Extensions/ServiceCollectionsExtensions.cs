using Microsoft.Extensions.DependencyInjection;

namespace Hotels.Application.Extensions;

public static class ServiceCollectionsExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        var applicationAssembly = typeof(ServiceCollectionsExtensions).Assembly;
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));

        services.AddAutoMapper(applicationAssembly);
        services.AddHttpContextAccessor();

        // services.AddScoped<IValidator<CreateHotelCommand>, CreateHotelCommandValidator>();


        // ValidatorOptions.Global.LanguageManager = new LanguageManager()
        // {
        //     Culture = new CultureInfo("el")
        // };
    }
}