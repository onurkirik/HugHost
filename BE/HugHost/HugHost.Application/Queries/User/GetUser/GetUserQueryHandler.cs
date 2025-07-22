using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs;
using MapsterMapper;
using MediatR;

namespace HugHost.Application.Queries.User.GetUser;

public class GetUserQueryHandler(IUserService userService, IMapper mapper)
    : IRequestHandler<GetUserQuery, QueryResponse<UserDto>>
{
    public async Task<QueryResponse<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userService.GetUserAsync(d => d.Id == request.Id);

        if (user is null)
            return QueryResponse<UserDto>.NotFound();

        var userDto = mapper.Map<UserDto>(user);

        return QueryResponse<UserDto>.Ok(userDto);
    }
}