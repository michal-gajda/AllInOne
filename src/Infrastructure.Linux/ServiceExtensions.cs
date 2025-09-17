namespace AllInOne.Infrastructure;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddLinux(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
