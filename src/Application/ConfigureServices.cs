﻿using CleanArchitectureBDD.Application.Commands.AddToBasket;
using FluentValidation;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services
            .AddScoped<IValidator<AddToBasketCommand>, AddToBasketCommandValidator>();

        return services;
    }
}
