using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using Mapster;
using MapsterMapper;
using MediatR;

namespace HugHost.Application.Queries.User.GetUser;

public class GetUserQueryHandler(IUserService userService)
    : IRequestHandler<GetUserQuery, QueryResponse<UserDto>>
{
    public async Task<QueryResponse<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userService.GetUserAsync(d => d.Id == request.Id);

        if (user is null)
            return QueryResponse<UserDto>.NotFound();

        var userDto = user.Adapt<UserDto>();

        return QueryResponse<UserDto>.Ok(userDto);
    }
}