using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using Mediator.Net.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Application.Queries.Role.GetRole;

public record GetRoleQuery([FromQuery] Guid Id) : IRequest<QueryResponse<RoleDto>>;