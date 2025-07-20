using HugHost.Application.Queries.User.GetUser;
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
    public async Task<ActionResult<GetUserQueryResponse>> GetUser([FromQuery] GetUserQuery request)
    {
        return await _mediator.Send(request);
    }
}