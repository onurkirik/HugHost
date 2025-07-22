using HugHost.Application.Commands.Role.CreateRole;
using HugHost.Application.Commands.Role.UpdateRole;
using HugHost.Application.Common.Responses;
using HugHost.Application.Queries.Role.GetRole;
using HugHost.Application.Queries.Role.GetRoles;
using HugHost.Application.Shared.DTOs.Role;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Presentation.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class RoleController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<QueryResponse<RoleDto>>> GetRole([FromQuery] GetRoleQuery request)
    {
        return await _mediator.Send(request);
    }

    [HttpGet]
    public async Task<ActionResult<QueryResponse<IEnumerable<RoleDto>>>> GetRoles([FromQuery] GetRolesQuery request)
    {
        return await _mediator.Send(request);
    }

    [HttpPost]
    public async Task<ActionResult<CommandResponse<RoleDto>>> CreateRole([FromBody] CreateRoleCommand request)
    {
        return await _mediator.Send(request);
    }

    [HttpPut]
    public async Task<ActionResult<CommandResponse<RoleDto>>> UpdateRole([FromBody] UpdateRoleCommand request)
    {
        return await _mediator.Send(request);
    }
}