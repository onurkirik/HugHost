using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using MediatR;

namespace HugHost.Application.Queries.Role.GetRole;

public record GetRoleQuery(Guid Id) : IRequest<QueryResponse<RoleDto>>;