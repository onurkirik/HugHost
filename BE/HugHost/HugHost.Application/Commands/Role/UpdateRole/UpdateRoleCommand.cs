using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using MediatR;

namespace HugHost.Application.Commands.Role.UpdateRole;

public record UpdateRoleCommand(UpdateRoleDto Role) : IRequest<CommandResponse<RoleDto>>;