using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using Mediator.Net.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Application.Commands.Role.CreateRole;

public record CreateRoleCommand([FromBody] CreateRoleDto Role) : IRequest<CommandResponse<RoleDto>>;