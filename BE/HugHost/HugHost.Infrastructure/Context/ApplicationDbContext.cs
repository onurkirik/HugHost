using HugHost.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HugHost.Infrastructure.Context;

public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
{
    public DbSet<ActivityLog> ActivityLogs { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}