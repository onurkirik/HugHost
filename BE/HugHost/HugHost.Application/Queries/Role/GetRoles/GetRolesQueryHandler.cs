using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using Mapster;
using MediatR;

namespace HugHost.Application.Queries.Role.GetRoles;

public class GetRolesQueryHandler(IRoleService roleService)
    : IRequestHandler<GetRolesQuery, QueryResponse<IEnumerable<RoleDto>>>
{
    public async Task<QueryResponse<IEnumerable<RoleDto>>> Handle(GetRolesQuery request,
        CancellationToken cancellationToken)
    {
        IEnumerable<Domain.Entities.Role?>? roles = await roleService.GetRolesAsync(d => true);
        if (roles is null)
            return QueryResponse<IEnumerable<RoleDto>>.NotFound();

        IEnumerable<RoleDto> rolesDto = roles.Adapt<IEnumerable<RoleDto>>();

        return QueryResponse<IEnumerable<RoleDto>>.Ok(rolesDto);
    }
}