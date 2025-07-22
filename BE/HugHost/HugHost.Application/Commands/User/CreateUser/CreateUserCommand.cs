using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using MediatR;

namespace HugHost.Application.Commands.User.CreateUser;

public record CreateUserCommand(CreateUserDto User) : IRequest<CommandResponse<UserDto>>;