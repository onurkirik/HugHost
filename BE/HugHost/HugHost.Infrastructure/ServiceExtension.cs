using HugHost.Application.Common.Interfaces.Repositories;
using HugHost.Application.Common.Interfaces.Services;
using HugHost.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HugHost.Infrastructure.Context;
using HugHost.Infrastructure.Persistence.Repositories;
using HugHost.Infrastructure.Persistence.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace HugHost.Infrastructure;

public static class ServiceExtension
{
    public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
    {
        // database connection
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("HugHostConnection")));

        // repositories
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<UserManager<Identity.Entities.User>>();
        services.AddScoped(typeof(IGenericRepository<Identity.Entities.User>),
            typeof(GenericRepository<Identity.Entities.User>));

        // services
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}