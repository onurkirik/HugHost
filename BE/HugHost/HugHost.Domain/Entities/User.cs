using HugHost.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HugHost.Domain.Entities;

public class User : IdentityUser<Guid>
{
    public required string FullName { get; set; }
}