

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fitfuel.Notifications.API;

public static class Dependencies
{
    public static IServiceCollection AddNotificationsModule(this IServiceCollection services, 
        IConfiguration configuration)
    {
        return services;
    }
    
    public static IApplicationBuilder UseNotificationsModule(this IApplicationBuilder app)
    {
        return app;
    }
}