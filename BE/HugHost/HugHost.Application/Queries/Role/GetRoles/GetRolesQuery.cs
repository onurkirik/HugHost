using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using MediatR;

namespace HugHost.Application.Queries.Role.GetRoles;

public record GetRolesQuery() : IRequest<QueryResponse<IEnumerable<RoleDto>>>;