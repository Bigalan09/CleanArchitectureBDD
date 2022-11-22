using CleanArchitectureBDD.Application.Basket.AddToBasket;
using FluentValidation;
using MediatR;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services
            .AddMediatR(Assembly.GetExecutingAssembly())
            .AddScoped<IValidator<AddToBasketCommand>, AddToBasketCommandValidator>();

        return services;
    }
}
