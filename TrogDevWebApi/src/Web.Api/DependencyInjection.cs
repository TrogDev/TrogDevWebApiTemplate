namespace Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        return services;
    }
}
