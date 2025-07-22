using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using Mapster;
using MediatR;

namespace HugHost.Application.Queries.Role.GetRole;

public class GetRoleQueryHandler(IRoleService roleService) : IRequestHandler<GetRoleQuery, QueryResponse<RoleDto>>
{
    public async Task<QueryResponse<RoleDto>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
    {
        Domain.Entities.Role? role = await roleService.GetRoleAsync(d => d.Id == request.Id);
        if (role is null)
            return QueryResponse<RoleDto>.NotFound();

        RoleDto roleDto = role.Adapt<RoleDto>();

        return QueryResponse<RoleDto>.Ok(roleDto);
    }
}