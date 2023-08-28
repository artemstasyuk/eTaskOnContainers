using eTaskOnContainers.ApplicationCore.Abstractions;
using eTaskOnContainers.Infrastructure.Persistence;
using eTaskOnContainers.Infrastructure.Persistence.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace eTaskOnContainers.Infrastructure;

public static class Dependencies
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, 
        IHostBuilder host)
    {
        services
            .AddPersistence()
            .AddLogging(configuration, host);
        
        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddPostgres();
        services.AddScoped(typeof(IRepository<>),typeof(EfRepository<>));
        return services;
    }
    
    private static void AddLogging(this IServiceCollection services, IConfiguration configuration,
        IHostBuilder host)
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

        host.UseSerilog(logger);
    }
}