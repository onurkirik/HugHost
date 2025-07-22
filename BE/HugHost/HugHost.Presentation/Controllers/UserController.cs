using HugHost.Application.Common.Responses;
using HugHost.Application.Queries.User.GetUser;
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
}