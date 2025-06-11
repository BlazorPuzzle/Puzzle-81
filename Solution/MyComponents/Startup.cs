using Microsoft.Extensions.DependencyInjection;
using Shared;

namespace MyComponents;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDashboardComponents(this IServiceCollection services)
    {
        services.AddScoped<IDashboardComponent, SalesChart>();
        services.AddScoped<IDashboardComponent, KPISummary>();
        services.AddScoped<IDashboardComponent, TeamActivity>();
        
        return services;
    }
}