using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HugHost.Infrastructure.Context;
using Microsoft.Extensions.Configuration;

namespace HugHost.Infrastructure;

public static class ServiceExtension
{
    public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
    {
        // database connection
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("HugHostConnection")));

        return services;
    }
}