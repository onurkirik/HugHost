using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Application.Commands.Role.UpdateRole;

public record UpdateRoleCommand([FromBody] UpdateRoleDto Role) : IRequest<CommandResponse<RoleDto>>;