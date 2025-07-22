using HugHost.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HugHost.Domain.Entities;

public class User : IdentityUser<Guid>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string FullName { get; set; }
}