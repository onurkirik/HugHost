namespace HugHost.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public required string FullName { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
}