using Hotels.API.Extensions;
using Hotels.API.Middlewares;
using Hotels.Application.Extensions;
using Hotels.Domain.Entities;
using Hotels.Infrastructure.Extensions;
using Microsoft.OpenApi.Models;


namespace Hotels.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddPresentation();
        builder.Services.AddInfrastructure(builder.Configuration);
        builder.Services.AddApplication();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseMiddleware<ErrorHandlingMiddleware>();
        
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        
        app.MapGroup("api/identity").MapIdentityApi<User>();
        
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}