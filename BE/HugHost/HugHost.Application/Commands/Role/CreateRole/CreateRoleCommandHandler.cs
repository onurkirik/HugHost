using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.Role;
using Mapster;
using MediatR;

namespace HugHost.Application.Commands.Role.CreateRole;

public class CreateRoleCommandHandler(IRoleService roleService)
    : IRequestHandler<CreateRoleCommand, CommandResponse<RoleDto>>
{
    public async Task<CommandResponse<RoleDto>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Role role = request.Role.Adapt<Domain.Entities.Role>();

        Domain.Entities.Role result = await roleService.AddAsync(role);

        RoleDto roleDto = request.Role.Adapt<RoleDto>();

        return CommandResponse<RoleDto>.Ok(roleDto);
    }
}