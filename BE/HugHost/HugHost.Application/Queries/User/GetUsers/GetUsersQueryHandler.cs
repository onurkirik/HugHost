using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using Mapster;
using MediatR;

namespace HugHost.Application.Queries.User.GetUsers;

public class GetUsersQueryHandler(IUserService userService)
    : IRequestHandler<GetUsersQuery, QueryResponse<IEnumerable<UserDto>>>
{
    public async Task<QueryResponse<IEnumerable<UserDto>>> Handle(GetUsersQuery request,
        CancellationToken cancellationToken)
    {
        IEnumerable<Domain.Entities.User?>? users = await userService.GetUsersAsync(d => true);
        if (users is null)
            return QueryResponse<IEnumerable<UserDto>>.NotFound();

        IEnumerable<UserDto?>? userDtos = users.Adapt<IEnumerable<UserDto>>();

        return QueryResponse<IEnumerable<UserDto>>.Ok(userDtos);
    }
}