namespace HugHost.Application.Shared.DTOs.Role;

public class UpdateRoleDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}