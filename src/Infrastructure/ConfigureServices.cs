using CleanArchitectureBDD.Application.Common;
using CleanArchitectureBDD.Infrastructure.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services
            .AddTransient<IDateTime, DateTimeService>();

        return services;
    }
}
