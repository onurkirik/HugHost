using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Application.Commands.User.CreateUser;

public record CreateUserCommand([FromBody] CreateUserDto User) : IRequest<CommandResponse<UserDto>>;