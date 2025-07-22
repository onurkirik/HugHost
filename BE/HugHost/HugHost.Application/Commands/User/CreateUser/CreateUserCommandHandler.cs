using HugHost.Application.Common.Interfaces.Services;
using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using Mapster;
using MapsterMapper;
using MediatR;

namespace HugHost.Application.Commands.User.CreateUser;

public class CreateUserCommandHandler(IUserService userService) : IRequestHandler<CreateUserCommand, CommandResponse<UserDto>>
{
    public async Task<CommandResponse<UserDto>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = request.User.Adapt<Domain.Entities.User>();
        
        var result = await userService.AddAsync(user);

        var resultDto = result.Adapt<UserDto>();

        return CommandResponse<UserDto>.Ok(resultDto);
    }
}