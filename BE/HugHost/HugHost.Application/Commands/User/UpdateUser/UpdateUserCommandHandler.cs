using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using Mapster;
using MediatR;

namespace HugHost.Application.Commands.User.UpdateUser;

public class UpdateUserCommandHandler(IUserService userService)
    : IRequestHandler<UpdateUserCommand, CommandResponse<UserDto>>
{
    public async Task<CommandResponse<UserDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.User user = request.User.Adapt<Domain.Entities.User>();

        Domain.Entities.User result = await userService.UpdateAsync(user);
 
        UserDto resultDto = result.Adapt<UserDto>();

        return CommandResponse<UserDto>.Ok(resultDto);
    }
}