using Microsoft.Extensions.DependencyInjection;

namespace eTaskOnContainers.ApplicationCore;

public static class Dependencies
{
    public static IServiceCollection AddApplicationCore(this IServiceCollection services)
    {
        return services;
    }
}