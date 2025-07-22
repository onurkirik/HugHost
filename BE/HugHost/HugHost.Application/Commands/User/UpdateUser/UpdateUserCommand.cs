using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using MediatR;

namespace HugHost.Application.Commands.User.UpdateUser;

public record UpdateUserCommand(UpdateUserDto User) : IRequest<CommandResponse<UserDto>>;