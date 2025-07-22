using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using MediatR;

namespace HugHost.Application.Commands.Role.CreateRole;

public record CreateRoleCommand(CreateRoleDto Role) : IRequest<CommandResponse<RoleDto>>;