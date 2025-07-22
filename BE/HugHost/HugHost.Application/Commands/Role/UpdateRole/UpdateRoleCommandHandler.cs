using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using Mapster;
using MediatR;

namespace HugHost.Application.Commands.Role.UpdateRole;

public class UpdateRoleCommandHandler(IRoleService roleService)
    : IRequestHandler<UpdateRoleCommand, CommandResponse<RoleDto>>
{
    public async Task<CommandResponse<RoleDto>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Role role = request.Role.Adapt<Domain.Entities.Role>();

        Domain.Entities.Role result = await roleService.UpdateAsync(role);
        RoleDto resultDto = result.Adapt<RoleDto>();

        return CommandResponse<RoleDto>.Ok(resultDto);
    }
}