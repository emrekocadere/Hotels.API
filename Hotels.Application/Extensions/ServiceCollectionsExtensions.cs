using System.Globalization;
using Hotels.Application.Hotels;
using Hotels.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.Resources;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Dtos;
using Hotels.Application.Hotels.Validators;

namespace Hotels.Application.Extensions;

public static class ServiceCollectionsExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {

        var applicationAssembly= typeof(ServiceCollectionsExtensions).Assembly;
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));
        
        services.AddAutoMapper(applicationAssembly);
        
        
       // services.AddScoped<IValidator<CreateHotelCommand>, CreateHotelCommandValidator>();
        
        
        // ValidatorOptions.Global.LanguageManager = new LanguageManager()
        // {
        //     Culture = new CultureInfo("el")
        // };
    }
}