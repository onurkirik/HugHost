using Microsoft.AspNetCore.Identity;

namespace HugHost.Infrastructure.Identity.Entities;

public class User : IdentityUser<Guid>
{
    public required string FullName { get; set; }
}