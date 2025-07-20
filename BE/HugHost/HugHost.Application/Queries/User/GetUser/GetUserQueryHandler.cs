using HugHost.Application.Common.Interfaces.Services;
using MediatR;

namespace HugHost.Application.Queries.User.GetUser;

public class GetUserQueryHandler(IUserService userService) : IRequestHandler<GetUserQuery, GetUserQueryResponse>
{
    public async Task<GetUserQueryResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userService.GetUserAsync(d => d.Id == request.Id);

        return new GetUserQueryResponse
        {
            Result = user
        };
    }
}