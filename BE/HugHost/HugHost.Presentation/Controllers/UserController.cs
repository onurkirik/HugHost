using HugHost.Application.Commands.User.CreateUser;
using HugHost.Application.Commands.User.UpdateUser;
using HugHost.Application.Common.Responses;
using HugHost.Application.Queries.User.GetUser;
using HugHost.Application.Queries.User.GetUsers;
using HugHost.Application.Shared.DTOs.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Presentation.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<QueryResponse<UserDto>>> GetUser([FromQuery] GetUserQuery request)
    {
        return await _mediator.Send(request);
    }

    [HttpGet]
    public async Task<ActionResult<QueryResponse<IEnumerable<UserDto>>>> GetUsers([FromQuery] GetUsersQuery request)
    {
        return await _mediator.Send(request);
    }

    [HttpPost]
    public async Task<ActionResult<CommandResponse<UserDto>>> CreateUser([FromBody] CreateUserCommand request)
    {
        return await _mediator.Send(request);
    }

    [HttpPut]
    public async Task<ActionResult<CommandResponse<UserDto>>> UpdateUser([FromBody] UpdateUserCommand request)
    {
        return await _mediator.Send(request);
    }
}